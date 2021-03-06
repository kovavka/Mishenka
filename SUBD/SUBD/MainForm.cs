﻿using System;
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
    public partial class MainForm : Form
    {
        private DataBaseContext dbContext;

        public MainForm()
        {
            InitializeComponent();

            loginTextEdit.NotNull();
            passwordTextEdit.NotNull();
            serverComboEdit.NotNull();
            checkBox.Checked = false;

            dbContext = new DataBaseContext();

            LoadServers();
        }

        private void LoadServers()
        {
            //TODO: загрузить серверы прямо серверы - List<Server>
            serverComboEdit.DataSource = dbContext.Servers.ToList();           
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                loginTextEdit.Enabled = true;
                passwordTextEdit.Enabled = true;
            }
            else
            {
                loginTextEdit.Enabled = false;
                passwordTextEdit.Enabled = false;
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (this.IsFormValid() && serverComboEdit.ValueIndex != -1)
            {
                if (!CheckConnection())
                {
                    ControlHelper.ShowError("Не удалось подключиться к серверу");
                    return;
                }

                Hide();
                new TableForm(GetServer(), dbContext).ShowDialog();
                Show();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new AddForm(dbContext).ShowDialog();

            LoadServers();
        }

        private bool CheckConnection()
        {
            var server = (Server) serverComboEdit.Value;

            var useAuth = checkBox.Checked;

            if (!useAuth)
                return !server.UseAuth;

            var login = loginTextEdit.Text;
            var password = passwordTextEdit.Text;

            return server.Login == login && PasswordHelper.VerifyHashedPassword(server.Password, password) && server.UseAuth;
        }

        private Server GetServer()
        {
            return (Server) serverComboEdit.Value;
        }
    }
}
