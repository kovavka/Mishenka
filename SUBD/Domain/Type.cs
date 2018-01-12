﻿namespace Domain
{
    public class Type
    {
        public virtual string Name { get; set; }
        
        public virtual string SqlName { get; set; }
        
        public virtual bool IsEnumerable { get; set; }
    }
}