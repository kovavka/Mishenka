﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        int Id { get; set; }
    }
    
    public class Entity: IEntity
    {
        public virtual int Id { get; set; }
    }
}
