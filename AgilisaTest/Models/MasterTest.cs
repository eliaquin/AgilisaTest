﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilisaTest.Models
{
    public class MasterTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DetailsTest> Details { get; set; }
    }
}
