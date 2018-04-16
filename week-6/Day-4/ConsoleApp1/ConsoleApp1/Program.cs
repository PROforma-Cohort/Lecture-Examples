using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static Func<char,bool > IsVowel = x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u';

        static void Main(string[] args)
        {
        }
    }
}
