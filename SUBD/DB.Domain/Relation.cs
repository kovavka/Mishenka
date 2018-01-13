namespace Domain
{
    public class Relation: Entity
    {
        public virtual RelationType RelationType { get; set; }
        
        public virtual Table SourceTable { get; set; }
        
        public virtual Table DestinationTable { get; set; }
    }
}