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
    public partial class MaskForm : Form
    {
        private readonly Server server;
        BindingList<Mask> dataSource = new BindingList<Mask>();
        DataBaseContext dbContext;

        public MaskForm(Server server, DataBaseContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.server = server;
            Text = "Data Source = " + server.Address;

            LoadDatabases();
        }

        private void LoadDatabases()
        {
            //TODO: загрузить
            dataSource = new BindingList<Mask>(server.Masks.WithEnumerable().ToList());

            new GridViewCreator<Mask>(gridView, dataSource)
                .Column("Наименование", x => x.Name).NotNull()
                .Column("Минимальное значение", x => x.MinValue)
                .Column("Максимальное значение", x => x.MaxValue)
                .Column("Выражение", x => x.MaskTemplate)
                .Column("Максимальная длина", x => x.MaxLength);
        }

        private void save_Click(object sender, EventArgs e)
        {
            //TODO: сохранить сохранить в бд dataSource
            // ??

            foreach (var x in dataSource)
            {
                if (x.Id == 0)
                {
                    dbContext.Servers.Find(server.Id).Masks.Add(x);
                }
            }

            dbContext.SaveChanges();

            Close();
        }
    }
}
