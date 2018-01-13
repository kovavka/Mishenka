using FluentNHibernate.Mapping;
using Domain;

namespace Infrastucture.Mappings
{
    public class EntityMap<T> : ClassMap<T> where T : IEntity
    {
        public EntityMap()
        {
            Cache.ReadWrite();
            Id(x => x.Id);
        }
    }
}
