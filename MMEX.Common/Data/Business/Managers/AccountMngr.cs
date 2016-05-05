using MMEX.Common.Data.DataAccess;
using MMEX.Common.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEX.Common.Data.Business.Managers
{
    public class AccountMngr
    {
        private readonly AccountRepository _repository;

        private string _DbPath = null;

        public AccountMngr(string DbPath)
        {
            _DbPath = DbPath;
            _repository = new AccountRepository(_DbPath);
        }

        public Account GetByKey(int id)
        {
            return _repository.GetById(id);
        }

        public IList<Account> GetAll()
        {
            return new List<Account>(_repository.GetAll());
        }

        public int Save(Account account)
        {
            return _repository.Save(account);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
