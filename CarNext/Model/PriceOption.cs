﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Model
{
    public class PriceOption
    {
        public string Category { get; set; }
        public string CategoryDescription { get; set; }
        public string Tag { get; set; }
        public List<PriceDetail> PriceDetails { get; set; }
    }

    public class PriceDetail
    {
        public double Price { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
        public string ArrivalETA { get; set; }
    }
}
