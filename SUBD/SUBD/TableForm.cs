using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;
using Domain;

namespace SUBD
{
    public partial class TableForm : Form
    {
        
        private  Server server;
        private readonly List<BindingDataBase> bindingDataBases = new List<BindingDataBase>();
        

        private DataBaseContext dbContext;

        public TableForm(Server server, DataBaseContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.server = server;
            Text = "Data Source = " + server.Address;
            dbComboEdit.CanWrite = false;

            dbComboEdit.SelectedIndexChanged += SelectedIndexChange;

            LoadDBs();
        }

        private int lastDatabaseId = -1;
        private void SelectedIndexChange(object sended, EventArgs args)
        {
            if (Relations != null && Tables != null)
            {
                Last.Relations = Relations;
                Last.Tables = Tables;
                
                Relations = new BindingList<Relation>(Current.Relations.ToList());
                Tables = new BindingList<Table>(Current.Tables.ToList());

                RecreateGrids();
            }

            gridViewTables.ClearSelection();
            Columns = null;
            RecreateColumns();


            lastDatabaseId = Database.Id;
        }

        private BindingDataBase Last
        {
            get { return bindingDataBases.Find(x => x.Database == lastDatabaseId); }
        }

        private BindingDataBase Current
        {
            get { return bindingDataBases.Find(x => x.Database == Database.Id); }
        }

        private void LoadDBs()
        {
            //TODO: загрузить дб - List<Database>

            server = dbContext.Servers.Find(server.Id);
            
            dbComboEdit.DataSource = server.Databases;
            
            foreach (var dataBase in server.Databases)
            {
                if (bindingDataBases.All(x => x.Database != dataBase.Id))
                    bindingDataBases.Add(new BindingDataBase()
                    {
                        Database = dataBase.Id,
                        Relations = new BindingList<Relation>(dataBase.Relations.WithEnumerable().ToList()),
                        Tables = new BindingList<Table>(dataBase.Tables.WithEnumerable().ToList()),
                    });
            }
            var bindsToRemove = new List<BindingDataBase>();
            foreach (var bind in bindingDataBases)
            {
                if (server.Databases.All(x => x.Id != bind.Database))
                    bindsToRemove.Add(bind);
            }
            foreach (var bind in bindsToRemove)
            {
                bindingDataBases.Remove(bind);
            }

            if (Relations != null || Tables != null)
            {
                Last.Relations = Relations;
                Last.Tables = Tables;
            }
            else
            {
                Relations = new BindingList<Relation>(Database.Relations.ToList());
                Tables = new BindingList<Table>(Database.Tables.ToList());
            }

            foreach (var db in bindingDataBases)
            {
                foreach (var table in Database.Tables)
                {

                    if (db.BindingTables.All(x => x.Table != table.Id))
                        db.BindingTables.Add(new BindingTable()
                        {
                            Table = table.Id,
                            Columns = new BindingList<Column>(table.Columns.ToList())
                        });
                }
                var tableToRemove = new List<BindingTable>();
                foreach (var table in db.BindingTables)
                {
                    if (Database.Tables.All(x => x.Id != table.Table))
                        tableToRemove.Add(table);
                }
                foreach (var table in tableToRemove)
                {
                    db.BindingTables.Remove(table);
                }


                var maskToRemove = new List<int>();
                foreach (var mask in db.BindingTables.SelectMany(x => x.Columns.Where(xx => xx.Mask != null).Select(xx => xx.Mask.Id)).Distinct())
                {
                    if (server.Masks.All(x => x.Id != mask))
                        maskToRemove.Add(mask);
                }
                foreach (var table in db.BindingTables)
                {
                    foreach (var column in table.Columns.Where(x => x.Mask != null))
                        if (maskToRemove.Contains(column.Mask.Id))
                            column.Mask = null;
                }
            }
            RecreateGrids();
        }

        private void RecreateGrids()
        {
            new GridViewCreator<Table>(gridViewTables, Tables)
                .Column("Наименование", x => x.Name).NotNull();


            new GridViewCreator<Relation>(gridViewRelations, Relations)
                .Column("Наименование", x => x.Name).NotNull()
                .Column("Атрибут 1", x => x.SourceColumn).ReadOnly()
                .Column("Атрибут 2", x => x.DestinationColumn).ReadOnly();

            RecreateColumns();
        }

        private void RecreateColumns()
        {
            if (Columns != null)
                new GridViewCreator<Column>(gridViewColumns, Columns)
                    .Column("Наименование", x => x.Name).NotNull()
                    .Column("Значение по умолчанию", x => x.DefaultValue).ReadOnly()
                    .Column("Тип", x => x.Type).ReadOnly()
                    .Column("Маска", x => x.Mask).ReadOnly()
                    .Column("Уникальный", x => x.IsUnique)
                    .Column("NotNull", x => x.IsNotNull)
                    .Column("Автоинкрементный", x => x.IsAutoIncrement)
                    .Column("Первичный ключ", x => x.IsPrimaryKey);
            else gridViewColumns.DataSource = null;

            gridViewColumns.Width = 1000;
        }


        private Database Database
        {
            get {return (Database)dbComboEdit.Value; }
        }

        private BindingList<Relation> Relations;
        private BindingList<Table> Tables;
        private BindingList<Column> Columns;

        private void manage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DBForm(server, dbContext).ShowDialog();
            LoadDBs();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //TODO тут вот сохранить данные из BindingDataBase
            //а остальное удалить, чего не будет в BindingDataBase
        }

        private void gridViewRelations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var view = new RelationForm(server, Database, Current.Relations[e.RowIndex]);
            if (view.ShowDialog() == DialogResult.OK)
            {
                Current.Relations[e.RowIndex] = view.GetRelation();
                Relations = new BindingList<Relation>(Current.Relations.ToList());
                RecreateGrids();
            }
        }

        private void maskManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MaskForm(server, dbContext).ShowDialog();
            LoadDBs();
        }
        
        private void gridViewTables_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (Current.Tables.Count<= e.RowIndex)
                return;            

            foreach (var a in Columns)
            {
                if (a.Id is 0)
                {
                    
                }
                else
                {

                }
            }

           // Current.Tables[e.RowIndex].Columns = Columns;
        }

        private void gridViewTables_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Current.Tables.Count <= e.RowIndex)
            {

                RecreateColumns();
                return;
            }
            Columns = new BindingList<Column>(Current.Tables[e.RowIndex].Columns.WithEnumerable().ToList());
            RecreateColumns();
        }

        private void gridViewColumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var table = Tables.Where(x => x.Columns == Columns).First();

            var view = new ColumnForm(server, table);
           //nothing

           
            if (view.ShowDialog() == DialogResult.OK)
            {
                //table.Columns = view.Get

                //Current.Relations[e.RowIndex] = view.GetRelation();
                //Relations = new BindingList<Relation>(Current.Relations.ToList());
                //RecreateGrids();
            }
        }
    }

    class BindingDataBase // в чом
    {
        public int Database { get; set; }
        public BindingList<Relation> Relations { get; set; }
        public BindingList<Table> Tables { get; set; }
        public List<BindingTable> BindingTables = new List<BindingTable>();  //в чем их смысол галя
    }

    class BindingTable
    {
        public int Table { get; set; }
        public BindingList<Column> Columns { get; set; }
    }
    
}
