using System.Collections.Generic;

namespace Domain
{
    public class Database: Entity
    {
        public virtual string Name { get; set; }
        
        public virtual List<Table> Tables { get; set; }
    }
}
