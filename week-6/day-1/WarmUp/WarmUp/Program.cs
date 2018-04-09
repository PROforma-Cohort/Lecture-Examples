using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Program
    {

        static public int CountChars(string haystack, char needle)
        {
            return haystack.ToLower().Count(c => c == needle);
        }

        public static bool XO(string input)
        {
            return CountChars(input, 'o') == CountChars(input, 'x');
        }

        // void  means that nothing is returned

            // i wanted to create a method that prints the current time to the console
        static void PrintDate()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        static DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }


        static void Main(string[] args)
        {
             PrintDate();

            var pap = new Person()
            {
                Name = "Pap"
            };
            var auntie = new Person()
            {
                Name = "Annie"
            };

            pap.SayHello();
            auntie.SayHello();

            //var files = new FileWriter();
            FileWriter.SavePerson(pap);


            var fileWriter = new NonStaticFileWriter();
            fileWriter.SavePerson(pap);

            var now = DateTime.Now;

            var righNow = new DateTime();
            righNow.AddHours(5);

        }
    }
}
