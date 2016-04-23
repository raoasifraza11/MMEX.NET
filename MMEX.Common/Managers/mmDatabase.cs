using Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class mmDatabase
    {
        static object locker = new object();

        private SQLiteConnection _sqlconnection;

        public mmDatabase(string DbPath)
        {
            _sqlconnection = new SQLiteConnection(DbPath);
            _sqlconnection.CreateTable<Account>();
            _sqlconnection.CreateTable<OptionsDb>();
        }
    }
}
