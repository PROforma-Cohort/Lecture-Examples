using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ShoeAPI.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Style { get; set; } = "boot";

        [DefaultValue("black")]
        public string Color { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}