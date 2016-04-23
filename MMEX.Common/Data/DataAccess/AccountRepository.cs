using Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccess
{
    public class AccountRepository
    {
        SQLiteDatabase _db = null;

        public AccountRepository(string DbPath)
        {
            _db = new SQLiteDatabase(DbPath);
        }

        public Account GetAccount(int id)
        {
            return _db.GetItem<Account>(id);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _db.GetItems<Account>();
        }

        public int SaveAccount(Account account)
        {
            return _db.SaveItem<Account>(account);
        }

        public int DeleteAccount(int id)
        {
            return _db.DeleteItem<Account>(id);
        }
    }
}
