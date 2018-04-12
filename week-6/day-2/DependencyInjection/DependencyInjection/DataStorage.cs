using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DataStorage
    {

        public IStorage DataSource { get; set; }

        public DataStorage(IStorage storage)
        {
            this.DataSource = storage;
        }

        public DateTime SaveAccout(User user)
        {
            DataSource.SaveUser();
            return DateTime.Now;
        }

        public User GetAccounts(string username)
        {
            return DataSource.GetUser(username);
        }
    }
}
