using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? Born { get; set; }
        public DateTime? Died { get; set; }
    }
}