using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class CheckoutRecieptViewModel
    {
        public DateTime DueBackDate { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}