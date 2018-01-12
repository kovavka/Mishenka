namespace Domain
{
    public class Relation
    {
        public virtual int SourceTableId { get; set; }
        
        public virtual int DestinationTableId { get; set; }
    }
}