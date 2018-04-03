using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello," + name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            PrintGreeting("Mark");

            // CANNOT Defined a void type
            // const x = 5
            const int x = 5;
            // let y = 6
            int y = 6;

            // decimal, double and float
            decimal cost = (decimal)3.50;
            double age = 29.5;
            float gasTank = 0.74f;

            // string
            string Message = "Hey there!";
            // const letter = 'a'
            char middleInitial = 't';

            // array
            string[] names = new string[4];
            // 4 string in names
            string firstInLine = names[0];

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers);

            double[] values = new double[5];
            // 5 double in values 
            List<int> scores = new List<int>();
            scores.Add(89);
            scores.Add(3);
            scores.Add(5);
            var first = scores[0];

            var myNumber = 5;
            var cars = new string[] { "van", "car", "truck", "suv" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //myNumber = "GOod bye";
            int count;

            Console.ReadLine();
        }
    }
}
