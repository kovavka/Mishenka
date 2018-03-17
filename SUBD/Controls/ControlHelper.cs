using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public class ControlHelper
    {
        public static bool IsFormValid(Type type)
        {
            var t = type.GetFields(BindingFlags.NonPublic).Where(x => x.FieldType.IsSubclassOf(typeof(TextEdit)));
            return true;
            //type.
        }
    }
}
