﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Model
{
    public class Personal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string birth_place { get; set; }
        public int age { get; set; }
        public decimal salary { get; set; }
    }
}
