﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixItWebAPI.Models
{
    public class Location
    {
        public int CustomerCode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}