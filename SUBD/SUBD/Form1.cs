using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domain.DataBaseContext context = new Domain.DataBaseContext();

            Domain.Table table = new Domain.Table();
            table.Name = "table-1";
            context.Tables.Add(table);
            context.SaveChanges();

        }
    }
}
