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

namespace Controls
{
    [ToolboxItem(true)]
    public partial class ComboEdit : UserControl
    {
        private Func<int, bool> func;

        public event EventHandler<EventArgs> SelectedIndexChanged = delegate { };

        public ComboEdit()
        {
            InitializeComponent();

            comboBox.SelectedIndexChanged += SelectedIndexChange;
            comboBox.EnabledChanged += EnabledChange;
            comboBox.Leave += Leave;
        }

        public void NotNull()
        {
            this.func = x => x != -1;
        }

        public bool IsValid()
        {
            var valid = CheckValidation();
            panel.BackColor = valid ? panel.ForeColor : Color.Red;
            return valid;
        }

        private bool CheckValidation()
        {
            if (func == null)
                return true;

            if (!Enabled)
                return true;

            return func(ValueIndex);
        }

        public bool CanWrite
        {
            set
            {
                if (value)
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;

                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public object Value
        {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        public int ValueIndex
        {
            get { return comboBox.SelectedIndex; }
            set { comboBox.SelectedIndex = value; }
        }

        public object DataSource
        {
            get { return comboBox.DataSource; }
            set { comboBox.DataSource = value; }
        }

        private void SelectedIndexChange(object sended, EventArgs args)
        {
            if (func != null)
                IsValid();

            SelectedIndexChanged(sended, args);
        }

        private void EnabledChange(object sended, EventArgs args)
        {
            if (func != null)
                IsValid();
        }

        private void Leave(object sended, EventArgs args)
        {
            if (func != null)
                IsValid();
        }

    }
}
