using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSQL
{
    class Dog
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAGoodBoy { get; set; }
        public string FurColor { get; set; }
        public string Owner { get; set; }

        public int? OwnerId { get; set; }

        public Dog()
        {

        }

        public Dog(SqlDataReader reader)
        {
            Name = reader["Name"].ToString();
            FurColor = reader["FurColor"].ToString();
            Id = (int)reader["ID"];
            IsAGoodBoy = (bool)reader["IsAGoodBoy"];
            Owner = reader["Owner"].ToString();
            OwnerId = reader["OwnerId"] as int?;
        }
    }
}
