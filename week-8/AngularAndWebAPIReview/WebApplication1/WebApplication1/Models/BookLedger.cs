using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BookLedger
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}