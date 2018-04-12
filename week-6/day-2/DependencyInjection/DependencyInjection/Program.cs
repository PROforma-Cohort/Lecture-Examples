using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// low level logic, should be passed in and you high level logic should not depend
// on the low level implimentaiton 



namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataStorage(new FileStorage());
            var apiService = new DataStorage(new APIDateStroage());

            var currentAcount = service.SaveAccout(new User());
        }
    }
}
