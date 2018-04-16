using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{
    /*
        PK ID
        nvarchar(25) Length
        nvarChar(25) COlor
        bit Bangs
        bit TiedUp
        Money Price
        nvarchar(25) Texture
         */

    public class HairStyles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HairLength { get; set; }
        public string Color { get; set; }
        public bool Bangs { get; set; }
        public bool TiedUp { get; set; }
        public decimal Price { get; set; }
        public string Texture { get; set; }

        public string Designer { get; set; }
        public bool? Highlights { get; set; }

    }
}
