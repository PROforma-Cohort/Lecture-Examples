using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ReadLine
// Lists
// LINQ
// Dictionaies
// Reading from Files

/*
 My Phone Book:

 - ask user: 
    - look at book
      -> display my phone books
    - add new
      -> enter in a name, 
           - prompt for name
           - reading a value from STNDIN
               - store in varible
         enter in a phone number
           - prompt for name
           - reading a value from STNDIN
               - store in varible
         store name/number somewhere
    - update a number


    */
namespace ListsAndDictionarys
{
    class Program
    {
        static void PrintPhoneBook(Dictionary<string, string> contactList)
        {
            Console.WriteLine("Total number of contacts: " + contactList.Count);
            Console.WriteLine("Your contact list:");
            Console.WriteLine("---------------------");
            foreach (var contact in contactList)
            {
                Console.WriteLine($"name: {contact.Key} number : {contact.Value}");
            }
        }


        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            const string FILE_PATH = "../../phonebook.csv";
            // read the contents of teh file, add to phonebook
            using (var reader = new StreamReader(FILE_PATH))
            {
                while (reader.Peek() > -1)
                {
                    var line = reader.ReadLine().Split(',');
                    phoneBook.Add(line[0], line[1]);
                }
            }

            var isRunning = true;
            while (isRunning)
            {
                // Promit user for action 
                Console.WriteLine("Do you want to (view), (lookup) or (add), or (exit) your phonebook");
                var command = Console.ReadLine();
                if (command == "view")
                {
                    //display phonebook
                    PrintPhoneBook(phoneBook);
                }
                else if (command == "exit")
                {
                    isRunning = false;
                }
                else if (command == "lookup")
                {
                    Console.WriteLine("Who do you want to look up?");
                    var nameToLookUp = Console.ReadLine().ToLower();
                    if (phoneBook.ContainsKey(nameToLookUp))
                    {
                        Console.WriteLine($"{nameToLookUp}'s numebr is {phoneBook[nameToLookUp]}");
                    }
                    else
                    {
                        Console.WriteLine("No number found");
                    }
                }
                else
                {
                    // get new information 
                    Console.WriteLine("Enter the new information, format: name number");
                    var data = Console.ReadLine().Split(' ');
                    var name = data[0];
                    var number = data[1];
                    Console.WriteLine($"You Added: {name}!");
                    phoneBook.Add(name.ToLower(), number);
                    PrintPhoneBook(phoneBook);

                    using (var writer = new StreamWriter(FILE_PATH))
                    {
                        foreach (var contact in phoneBook)
                        {
                            writer.WriteLine($"{contact.Key},{contact.Value}");
                        }
                    }

                }

            }
            Console.WriteLine("Goodbye");
        }
    }
}
