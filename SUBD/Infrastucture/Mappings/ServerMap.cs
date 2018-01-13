using Domain;
using Infrastucture.Mappings;

namespace Infrastucture
{
    namespace Costs.Infrastructure.Mappings
    {
        public class ServerMap : EntityMap<Server>
        {
            public ServerMap()
            {
                Map(x => x.Address);
                Map(x => x.Login).Unique();
                Map(x => x.Password).Nullable();

                //HasMany(x => x.Databases).AsBag().Cascade.AllDeleteOrphan();
            }
        }
    }
}
