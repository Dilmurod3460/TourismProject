﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism.Domain.Entities.Tours
{
    public class Tours
    {
        public int TourId { get; set; } 
        public string Name { get; set; }
        public string Duration {  get; set; }
        public string Price { get; set; }
        
    }
}
