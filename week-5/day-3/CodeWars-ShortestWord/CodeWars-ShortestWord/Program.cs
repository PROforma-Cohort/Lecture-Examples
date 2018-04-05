using System.Linq;

namespace CodeWars_ShortestWord
{
    class Program
    {

        public static int FindShort(string s)
                => s.Split(' ').Min(m => m.Length);
            // 1: .Min Method
            // 2: dictionary
            // 3: List, foreach, sorted by length, take first
            // 4: for loop & count , keep track as we go through 

        

        static void Main(string[] args)
        {

        }
    }
}
