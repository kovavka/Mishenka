using System.Collections.Generic;

namespace Domain
{
    public class Database: Entity
    {
        public virtual string Name { get; set; }
        
        public virtual ICollection<Table> Tables { get; set; }
    }
}
