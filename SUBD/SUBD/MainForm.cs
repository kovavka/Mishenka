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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loginTextEdit.NotNull();
            passwordTextEdit.NotNull();
            serverComboEdit.NotNull();
            checkBox.Checked = false;

            LoadServers();
        }

        private void LoadServers()
        {
            var table1 = new Table()
            {
                Name = "один"
            };

            table1.Columns = new List<Column>()
            {
                new Column()
                {
                    Name = "один",
                    Table = table1
                }
            };

            var table2 = new Table()
            {
                Name = "два",
            };
            table2.Columns = new List<Column>()
            {
                new Column()
                {
                    Name = "два",
                    Table = table2
                }
            };

            var list =new List<Server>()
            {
                new Server()
                {
                    Id=1,
                    Address = "df",
                    Databases = new List<Database>()
                    {
                        new Database()
                        {
                            Id= 1,
                            Name="33",
                            Relations = new List<Relation>()
                            {
                                new Relation()
                                {
                                    Name = "dd",
                                },
                                new Relation()
                                {
                                    Name = "dfdf",
                                }
                            },
                            Tables = new List<Table>()
                            {
                                table1,
                                table2
                            }
                        },
                        new Database()
                        {
                            Id= 2,
                            Name="три",
                            Relations=new List<Relation>(),
                            Tables = new List<Table>()
                            {
                                new Table()
                                {
                                    Name="три"
                                }
                            }
                        }
                    },
                    Masks = new List<Mask>()
                    {
                        new Mask()
                        {
                            Name = "ddd"
                        }
                    }
                },
                new Server()
                {
                    Id=22,
                    Address = "фвф",
                    Password =  PasswordHelper.GetHash("kwa"),
                    UseAuth = true,
                    Login = "1"
                },
            };

            //TODO: загрузить серверы прямо серверы - List<Server>
            serverComboEdit.DataSource = list;
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
                new TableForm(GetServer()).ShowDialog();
                Show();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();

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
