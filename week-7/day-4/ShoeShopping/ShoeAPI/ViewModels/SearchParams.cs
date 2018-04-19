using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeAPI.ViewModels
{

    public class SearchParams
    {
        public string Style { get; set; }
        public int? Size { get; set; }
        public string Color { get; set; }
    }
}