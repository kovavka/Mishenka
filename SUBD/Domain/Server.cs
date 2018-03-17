using System.Collections.Generic;

namespace Domain
{
    public class Server : Entity
    {
        public virtual string Address { get; set; }

        public virtual string Login { get; set; }

        public virtual string Password { get; set; }

        public virtual bool UseAuth { get; set; }
        
        public virtual ICollection<Database> Databases { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}