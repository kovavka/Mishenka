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

        public TableForm(Server server)
        {
            InitializeComponent();

            this.server = server;
            Text = "Data Source = " + server.Address;
            dbComboEdit.CanWrite = false;

            LoadDBs();
        }
        
        private void LoadDBs()
        {
            //TODO: загрузить дб - List<Database>
            dbComboEdit.DataSource = server.Databases;
        }

        private void manage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DBForm(server).ShowDialog();
            LoadDBs();
        }
    }
}
