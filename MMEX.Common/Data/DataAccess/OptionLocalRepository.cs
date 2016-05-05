using MMEX.Common.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEX.Common.Data.DataAccess
{
    public class OptionLocalRepository
    {
        SQLiteMmexIni _db = null;

        public OptionLocalRepository(string DbPath)
        {
            _db = new SQLiteMmexIni(DbPath);
        }

        public OptionLocal GetByKey(int id)
        {
            return _db.GetItem<OptionLocal>(id);
        }

        public OptionLocal GetByName(string Name)
        {
            return _db.GetItems<OptionLocal>()
                .Where(opt => opt.Name == Name)
                .FirstOrDefault();
        }

        public int SaveOptionLocal(OptionLocal option)
        {
            return _db.SaveItem<OptionLocal>(option);
        }

        public int DeleteOptionLocal(int id)
        {
            return _db.DeleteItem<OptionLocal>(id);
        }
    }
}
