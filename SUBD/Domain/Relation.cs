namespace Domain
{
    public class Relation: Entity
    {
        public virtual string Name { get; set; }

        public virtual Column SourceColumn { get; set; }
        
        public virtual Column DestinationColumn { get; set; }
    }
}