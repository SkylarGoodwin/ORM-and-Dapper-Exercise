﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class Product
    {
        public int ProductID {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool onSale { get; set; }
        public int stockLevel { get; set; }
    }
}
