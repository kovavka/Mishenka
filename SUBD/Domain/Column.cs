namespace Domain
{
    public class Column: Entity
    {
        //надеюсь, так будет работать, если что сделайте, как было
        //public virtual int TableId { get; set; }
        public virtual Table Table { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual object DefaultValue { get; set; }
        
        public virtual Type Type { get; set; }
        
        public virtual Mask Mask { get; set; }
        
        public virtual bool IsUnique { get; set; }
        
        public virtual bool IsNotNull { get; set; }
        
        public virtual bool IsAutoIncrement { get; set; }
        
        public virtual bool IsPrimaryKey { get; set; }

        public override string ToString()
        {
            return $"{Table.Name}.{Name}";
        }
    }
}