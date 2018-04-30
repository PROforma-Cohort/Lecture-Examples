using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DrawingHat.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [NotMapped]
        public List<People> People { get; set; } = new List<People>();
    }
}