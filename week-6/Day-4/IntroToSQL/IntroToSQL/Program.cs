using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 - LinqToSQL, not yet
    - "complexer", tries to do everything for you Framework

 - ADO.NET, today!
    - simple, "dumb" interface with SQL 

     */

namespace IntroToSQL
{
    class Program
    {

        static List<Dog> GetAllDogs(SqlConnection conn)
        {
            // Query the database
            var _select = "SELECT Dogs.ID, Dogs.Name, Dogs.FurColor, Dogs.IsAGoodBoy, Rescuers.Name AS Owner, Rescuers.ID as OwnerId" +
                " FROM Dogs" +
                " LEFT JOIN Rescuers ON Dogs.RescuerID = Rescuers.Id";
            var query = new SqlCommand(_select, conn);
            var reader = query.ExecuteReader();
            var _rv = new List<Dog>();
            // parse the results
            while (reader.Read())
            {
                var _dog = new Dog(reader);
                Console.WriteLine(_dog.Name + " has " + _dog.FurColor + "colored hair" + " Was adopted by" + _dog.Owner);
            }
            return _rv;
        }


        static void InsertDog(SqlConnection conn, Dog newDog)
        {
            var _insert = "INSERT INTO Dogs (Name, IsAGoodBoy, FurColor)" +
                "          VALUES (@Name, @IsAGoodBoy, @FurColor)";
            var cmd = new SqlCommand(_insert, conn);

            cmd.Parameters.AddWithValue("Name", newDog.Name);
            cmd.Parameters.AddWithValue("IsAGoodBoy", newDog.IsAGoodBoy);
            cmd.Parameters.AddWithValue("FurColor", newDog.FurColor);
            cmd.ExecuteScalar();
        }





        static void Main(string[] args)
        {
            // locaiton of database
            const string CONNECTION_STRING =
                @"Server=localhost\SQLEXPRESS01;Database=Kennel;Trusted_Connection=True;";
            // Open the connect
            //var conn2 = new SqlConnection(CONNECTION_STRING);, will not close the connection automatically
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                var newestDog = new Dog
                {
                    Name = "New dog at " + DateTime.Now, 
                    FurColor = "Blonde",
                    IsAGoodBoy = true,
                };
                var newerestDog = new Dog
                {
                    Name = "Toe-B",
                    FurColor = "Blonde",
                    IsAGoodBoy = true,
                };
                conn.Open();
                InsertDog(conn, newestDog);
                InsertDog(conn, newerestDog);
                GetAllDogs(conn);
               
                // close the conneciton 
            }

        }
    }
}

