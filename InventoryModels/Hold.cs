﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{  
    public class Hold 
    {
        public int Id { get; set; }

        public string Name { get; set; }   

        public TypeOfHold Type { get; set; }
    }
}
