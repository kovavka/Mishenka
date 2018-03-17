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
    public partial class ColumnForm : Form
    {
        private readonly Server server;
        private readonly Database database;
        BindingList<Database> dataSource = new BindingList<Database>();

        public ColumnForm(Server server)
        {
            InitializeComponent();

            this.server = server;
            Text = string.Format("Data Source = {0}; Initial Catalog = {1}", server.Address, database.Name);

            LoadDatabases();
        }

        private void LoadDatabases()
        {
            //TODO: загрузить дб - BindingList<Database> мб этого уже хватит я хз
            dataSource = new BindingList<Database>(server.Databases.ToList());

            new GridViewCreator<Database>(gridView, dataSource)
                .Column("Наименование", x => x.Name).NotNull();
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            //TODO: сохранить дб (dataSource)
            // ??

            Close();
        }
    }
}
