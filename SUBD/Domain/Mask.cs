
namespace Domain
{
    public class Mask: Entity
    {
        public virtual int MinValue { get; set; }
        
        public virtual int MaxValue { get; set; }
        
        public virtual string MaskTemplate { get; set; }
        
        public virtual string MaxLength { get; set; }
    }
}