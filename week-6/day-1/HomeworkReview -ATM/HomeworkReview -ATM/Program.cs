using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Biggest Question: Program Structure!!!!
// managing types and classes/objects , store info
// how to build classes, and how use in Main Program 

namespace HomeworkReview__ATM
{
    /* Explorer MOde: 
        - Checkings Account
            - width draw
            - deposit
        - Savings Account
            - width draw
            - deposit
        - transfer
        - log transactions


        Account Class
            - Balance
            - void WidthDraw
            - void Deposit
        
        var checking = new Account();
        var savings = new Account();

        -- for Users:
         new Class 
            - account name
            - pin
            - checkings
            - savings

    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter you name and pin");
            var nameAndPin = Console.ReadLine().Split(' ');
            var name = nameAndPin[0];
            var pin = nameAndPin[1];
            // if they werw in the same file, 
            // load all users, and then search the current user
            var path = "../../users.csv";
            var allUsers = new List<User>();
            using (var reader = new StreamReader(path))
            {
                while (reader.Peek() > -1)
                {
                    var data = reader.ReadLine();
                    allUsers.Add(new User(data));
                }
            }
            
            var currentUser = allUsers.FirstOrDefault(f => f.Pin == pin && f.AccountName == name);

            var isRunning = true;
            while (isRunning)
            {
                Console.WriteLine($"Checkings: {currentUser.Checking.Balance} Savings: {currentUser.Savings.Balance}");

                Console.WriteLine("---------------------");
                Console.WriteLine("What do you want to do:");
                Console.WriteLine("1) deposit into savings");
                Console.WriteLine("0) exit");
                var action = Console.ReadLine();

                if (action == "1")
                {
                    Console.WriteLine("How much?");
                    var amount = Console.ReadLine();
                    currentUser.Savings.Deposit(Double.Parse(amount));
                }
                else if (action == "0")
                {
                    isRunning = false;
                }
            }

            // write the current user to a file
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(currentUser.ToCSVFormat());
            }
            Console.WriteLine("Good Bye!");

        }
    }
}
