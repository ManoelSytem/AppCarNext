﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Model
{
    public class GooglePlace
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Raw { get; set; }

        public GooglePlace(JObject jsonObject)
        {
            Name = (string)jsonObject["result"]["name"];
            Latitude = (double)jsonObject["result"]["geometry"]["location"]["lat"];
            Longitude = (double)jsonObject["result"]["geometry"]["location"]["lng"];
            Raw = jsonObject.ToString();
        }
    }
}
