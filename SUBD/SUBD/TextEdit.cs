using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    [ToolboxItem(true)]
    public partial class TextEdit : UserControl
    {
        private List<Func<string, bool>> functions=new List<Func<string, bool>>();

        public TextEdit()
        {
            InitializeComponent();

            textBox.TextChanged += ValueChange;
            textBox.EnabledChanged += EnabledChange;
            textBox.Leave += Leave;
        }

        public void Validate(Func<string, bool> func)
        {
            this.functions.Add(func);
        }

        public void NotNull()
        {
            this.functions.Add(x=>!x.IsNullOrEmpty());
        }

        public bool IsValid()
        {
            var valid = CheckValidation();
            panel.BackColor = valid ? panel.ForeColor : Color.Red;
            return valid;
        }

        private bool CheckValidation()
        {
            if (!functions.Any())
                return true;

            if (!Enabled)
                return true;

            var isValid = true;

            functions.ForEach(x => isValid &= x(Text));
            return isValid;
        }
        
        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        private void ValueChange(object sended, EventArgs args)
        {
            if (functions.Any())
                IsValid();
        }

        private void EnabledChange(object sended, EventArgs args)
        {
            if (functions.Any())
                IsValid();
        }

        private void Leave(object sended, EventArgs args)
        {
            if (functions.Any())
                IsValid();
        }

    }
}
