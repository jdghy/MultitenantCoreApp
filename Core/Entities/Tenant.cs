﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Tenant
    {
        public string Name { get; set; }

        public Tenant(string name)
        {
            Name = name;
        }
    }
}
