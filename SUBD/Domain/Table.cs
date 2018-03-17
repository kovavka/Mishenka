using System.Collections.Generic;

namespace Domain
{
    public class Table: Entity
    {
        public virtual string Name { get; set; }
                
        public virtual ICollection<Column> Columns { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
