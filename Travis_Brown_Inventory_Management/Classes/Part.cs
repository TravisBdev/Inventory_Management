﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Inventory_Management.Classes {
    public abstract class Part {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //I may or may not need this constructor (probably not because of manual entry) Just in case though.

        //public Part(int partID, string name, decimal price, int inStock, int min, int max) {
        //    PartID = partID;
        //    Name = name;
        //    Price = price;
        //    InStock = inStock;
        //    Min = min;
        //    Max = max;
        //}
    }
}
