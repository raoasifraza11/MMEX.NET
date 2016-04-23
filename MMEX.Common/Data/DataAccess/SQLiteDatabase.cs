using Data.Business;
using Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccess
{
    public class SQLiteDatabase
    {
        static object locker = new object();

        SQLiteConnection database;

        public SQLiteDatabase(string DbPath)
        {
            // database = DependencyService.Get<ISQLite>().GetConnection();
            database = new SQLiteConnection(DbPath);
            database.CreateTable<Account>();
            database.CreateTable<OptionsDb>();
        }

        static readonly object Locker = new object();

        public IEnumerable<T> GetItems<T>() where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                return (from i in database.Table<T>() select i).ToList();
            }
        }

        public T GetItem<T> (int id) where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                return database.Table<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem<T> (T item) where T : Business.Contracts.IEntity
        {
            lock (Locker)
            {
                if (item.Id != 0)
                {
                    database.Update(item);
                    return item.Id;
                }
                return database.Insert(item);
            }
        }

        public int DeleteItem<T> (int id) where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                return database.Delete<T>(id);
            }
        }
    }
}
