using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace SUBD
{
    public partial class TableForm : Form
    {
        private readonly Server server;
        private readonly List<BindingDataBase> bindingDataBases = new List<BindingDataBase>();

        public TableForm(Server server)
        {
            InitializeComponent();

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
            dbComboEdit.DataSource = server.Databases;
            
            foreach (var dataBase in server.Databases)
            {
                if (bindingDataBases.All(x => x.Database != dataBase.Id))
                    bindingDataBases.Add(new BindingDataBase()
                    {
                        Database = dataBase.Id,
                        Relations = new BindingList<Relation>(dataBase.Relations.ToList()),
                        Tables = new BindingList<Table>(dataBase.Tables.ToList()),
                    });
            }

            Relations = new BindingList<Relation>(Database.Relations.ToList());
            Tables = new BindingList<Table>(Database.Tables.ToList());


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
            
        }

        private Database Database
        {
            get {return (Database)dbComboEdit.Value; }
        }

        private BindingList<Relation> Relations;
        private BindingList<Table> Tables;

        private void manage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DBForm(server).ShowDialog();
            LoadDBs();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //TODO тут вот сохранить данные из BindingDataBase
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
            new DBForm(server).ShowDialog();
            LoadDBs();
        }
    }

    class BindingDataBase
    {
        public int Database { get; set; }
        public BindingList<Relation> Relations { get; set; }
        public BindingList<Table> Tables { get; set; }
    }

    class BindingRelation
    {

        public virtual Table SourceTable { get; set; }

        public virtual Table DestinationTable { get; set; }
    }
}
