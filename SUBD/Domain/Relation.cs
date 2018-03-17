namespace Domain
{
    public class Relation: Entity
    {
        public virtual string Name { get; set; }

        public virtual Table SourceTable { get; set; }
        
        public virtual Table DestinationTable { get; set; }
    }
}