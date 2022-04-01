﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public  class Operation:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserOperation> Operations { get; set; }
    }
}
