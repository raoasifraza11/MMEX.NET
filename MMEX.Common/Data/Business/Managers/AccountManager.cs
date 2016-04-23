using Data.DataAccess;
using Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Business.Managers
{
    public class AccountManager
    {
        private readonly AccountRepository _repository;

        public AccountManager(string DbPath)
        {
            _repository = new AccountRepository(DbPath);
        }

        public Account GetAccount(int id)
        {
            return _repository.GetAccount(id);
        }

        public IList<Account> GetAccounts()
        {
            return new List<Account>(_repository.GetAccounts());
        }

        public int SaveAccount(Account acc)
        {
            return _repository.SaveAccount(acc);
        }

        public int DeleteAccount(int id)
        {
            return _repository.DeleteAccount(id);
        }
    }
}
