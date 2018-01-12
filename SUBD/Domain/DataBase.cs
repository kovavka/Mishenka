using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DataBase: Entity
    {
        public virtual string Name { get; set; }
        
        public virtual List<Table> Tables { get; set; }
    }
}
