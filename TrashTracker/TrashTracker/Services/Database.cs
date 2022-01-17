using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TrashTracker.Models;

namespace TrashTracker.Services
{
    public class Database
    {
        readonly SQLiteAsyncConnection _connection;
        public Database(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Trash>().Wait();
        }
        public Task<List<Trash>> GetAllTrashAsync()
        {
            return _connection.Table<Trash>().ToListAsync();
        }
        public Task<Trash> GetTrashAsync(string id)
        {
            return _connection.Table<Trash>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
        public Task<int> AddTrashAsync(Trash trash)
        {
            return _connection.InsertAsync(trash);
        }
        public Task<int> DeleteTrashAsync(Trash trash)
        {
            return _connection.DeleteAsync(trash);
        }
        public Task<int> DeleteAllTrashAsync()
        {
            return _connection.DeleteAllAsync<Trash>();
        }
    }
}
