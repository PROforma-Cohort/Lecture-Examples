using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeAPI.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}