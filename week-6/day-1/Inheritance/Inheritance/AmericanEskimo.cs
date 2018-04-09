using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AmericanEskimo:Dog
    {
        
    }
    class MiniAmericanEskimo: AmericanEskimo
    {
        public MiniAmericanEskimo()
        {
            this.Size = "mini";
        }
    }
}
