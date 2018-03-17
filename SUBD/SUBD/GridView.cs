using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;
using Domain;

namespace SUBD
{
    public partial class GridView : DataGridView
    {
        private readonly Dictionary<string, ValidationItem> validation = new Dictionary<string, ValidationItem>();
        
        public GridView()
        {
            InitializeComponent();

            CellValidating += gridView_CellValidating;
            DataError += onDataError;
        }
        
        private void gridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = Columns[e.ColumnIndex].DataPropertyName;
            
            if (!validation.ContainsKey(headerText)) return;

            var item = validation[headerText];
            
            if (!item.Func(e.FormattedValue))
            {
                Rows[e.RowIndex].ErrorText = item.ErrorMessage;
                e.Cancel = true;
            }
            else
                Rows[e.RowIndex].ErrorText = null;

        }

        public void AddValidation(string key, ValidationItem value)
        {
            validation.Add(key, value);
        }

        private void onDataError(object sender, EventArgs args)
        {
            ControlHelper.ShowError("Произошла ошибка, проверьте тип данных вводимого значения");
        }
    }

    public class ValidationItem
    {
        public string ErrorMessage { get; set; }
        public Func<object, bool> Func { get; set; }
    }

    public class GridViewCreator<T> where T: IEntity
    {
        private readonly GridView gridView;

        public GridViewCreator(GridView gridView, IList<T> dataSource)
        {
            this.gridView = gridView;
            gridView.DataSource = dataSource;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].Visible = false;
            }
        }

        private string lastColumnName;
        private string lastHeaderText;
        public GridViewCreator<T> Column<Y>(string caption, Expression<Func<T, Y>> valueAccessor)
        {
            var valueName = ReflectionHelper.GetMemberInfoPath(valueAccessor)[0].Name;

            gridView.Columns[valueName].Visible = true;
            gridView.Columns[valueName].HeaderText = caption;
            lastColumnName = valueName;
            lastHeaderText = caption;

            return this;
        }

        public GridViewCreator<T> Validate(Func<object, bool> func, string message)
        {
            if (lastColumnName.IsNullOrEmpty())
                throw new Exception();
            
            var val = new ValidationItem()
            {
                ErrorMessage = message,
                Func = func
            };

            gridView.AddValidation(lastColumnName, val);

            return this;
        }

        public GridViewCreator<T> NotNull()
        {
            return Validate(x => !x.ToString().IsNullOrEmpty(), lastHeaderText + "должно быть задано");
        }
    }
}
