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
    public partial class RelationForm : Form
    {
        private readonly Database database;
        private readonly Relation relation;

        public RelationForm(Server server, Database database, Relation relation)
        {
            InitializeComponent();

            this.database = database;
            this.relation = relation;
            Text = string.Format("Data Source = {0}; Initial Catalog = {1}", server.Address, database.Name);
            
            textEditName.NotNull();
            textEditName.Text = relation.Name;
            comboEditColumn1.NotNull();
            comboEditColumn2.NotNull();
            comboEditTable1.NotNull();
            comboEditTable2.NotNull();

            LoadTables();
        }

        public Relation GetRelation()
        {
            return relation;
        }

        private void LoadTables()
        {
            //TODO: загрузить 
            comboEditTable1.DataSource = database.Tables;
            comboEditTable2.DataSource = database.Tables;

            comboEditTable1.ValueIndex = -1;
            comboEditTable2.ValueIndex = -1;
        }

        private void LoadColumns()
        {
            //TODO: загрузить 
            comboEditColumn1.DataSource = ((Table) comboEditTable1.Value).With(x => x.Columns);
            comboEditColumn2.DataSource = ((Table)comboEditTable2.Value).With(x => x.Columns);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!this.IsFormValid())
                return;

            //TODO: сохранить дб (dataSource)
            // ??

            DialogResult = DialogResult.OK;

            relation.Name = textEditName.Text;
            relation.DestinationColumn = (Column)comboEditColumn2.Value;
            relation.SourceColumn = (Column)comboEditColumn1.Value;

            Close();
        }

        private void comboEditTable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEditTable2.DataSource = database.Tables.Except(((Table)comboEditTable1.Value).AsEnumerable()).ToList();
            LoadColumns();
        }

        private void comboEditTable2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEditTable1.DataSource = database.Tables.Except(((Table)comboEditTable2.Value).AsEnumerable()).ToList();
            LoadColumns();
        }
    }
}
