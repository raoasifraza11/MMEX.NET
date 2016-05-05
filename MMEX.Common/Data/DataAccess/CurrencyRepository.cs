using MMEX.Common.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEX.Common.Data.DataAccess
{
    public class CurrencyRepository
    {
        SQLiteDatabase _db = null;

        public CurrencyRepository(string DbPath)
        {
            _db = new SQLiteDatabase(DbPath);
        }

        public Currency GetByKey(int id)
        {
            return _db.GetItem<Currency>(id);
        }

        public IEnumerable<Currency> GetAll()
        {
            return _db.GetItems<Currency>();
        }

        public int Save(Currency currency)
        {
            return _db.SaveItem<Currency>(currency);
        }

        public int Delete(int id)
        {
            return _db.DeleteItem<Currency>(id);
        }
    }
}
