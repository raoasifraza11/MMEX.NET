using Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers
{
    public class AccountManagers
    {
        readonly mmDatabase _db = null;
        protected static string DbLocation;

        public AccountManagers(string DbPath)
        {
            _db = new mmDatabase(DbPath);
        }

        public Account GetByID(int AccountId)
        {
            if (AccountId < 0)
                throw new ArgumentOutOfRangeException("productID");

            return dbAccount[AccountId];
        }

        public IEnumerable<Account> GetAccounts()
        {
            return (from t in _sqlconnection.Table<Account>() select t);
        }
    }
}
