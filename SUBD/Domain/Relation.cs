namespace Domain
{
    public class Relation: Entity
    {
        public virtual int SourceTableId { get; set; }
        
        public virtual int DestinationTableId { get; set; }
    }
}