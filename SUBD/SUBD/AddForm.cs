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
    public partial class AddForm : Form
    {

        private DataBaseContext dbContext;

        public AddForm(DataBaseContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            login.NotNull();
            password.NotNull();
            server.NotNull();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                login.Enabled = true;
                password.Enabled = true;
            }
            else
            {
                login.Enabled = false;
                password.Enabled = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this.IsFormValid())
            {
                AddServer();
            }
        }

        private void AddServer()
        {
            var address = server.Text;
            var useAuth = checkBox.Checked;
            string log = null;
            string pass = null;
            if (useAuth)
            {
                log = login.Text;
                pass = PasswordHelper.GetHash(password.Text);
            }


            //TODO добавление сервера
            dbContext.Servers.Add(new Server() { Address = address, UseAuth = useAuth, Login = log, Password =  pass });
            dbContext.SaveChanges();
            this.Close();
        }
    }
}
