using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeAPI.Models
{
    public class Size
    {
        public int Id { get; set; }
        public int UsSize { get; set; }
        public int EuropeanSize { get; set; }
        // Wide, Narrow, Regular
        public ShoeWitdh Width { get; set; }
    }

    public enum ShoeWitdh
    {
        REGULAR = 0, 
        WIDE, 
        NARROW
    }
}