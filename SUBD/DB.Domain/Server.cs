using System.Collections.Generic;

namespace Domain
{
    public class Server : Entity
    {
        public virtual string Address { get; set; }

        public virtual List<Database> Databases { get; set; }
    }
}