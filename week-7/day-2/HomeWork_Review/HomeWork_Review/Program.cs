using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Review
{

    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAGoodBoy { get; set; }
        public double Age { get; set; }
        public DateTime Birthday { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var kennels = new List<Dog>();
            var pageSize = 10;
            var filterByGooBoy = true;
            var query = kennels.Where(w => w.Age > 5);
            if (filterByGooBoy)
            {
                query = query.Where(w => w.IsAGoodBoy);
            }
            query.OrderBy(o => o.Name).Take(pageSize);
        }   
    }
}
