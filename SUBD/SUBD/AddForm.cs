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

namespace SUBD
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

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
            //servers.Add(address, useAuth, log, pass);
        }
    }
}
