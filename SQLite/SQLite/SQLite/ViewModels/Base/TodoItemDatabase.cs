using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLite.ViewModels.Base
{
    public class TodoItemDatabase
    {
        #region Variables Globales
        readonly SQLiteAsyncConnection database;
        #endregion Variables Globales

        #region Constructor
        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TodoItem>().Wait();
        }
        #endregion Constructor

        #region Methods
        public Task<List<TodoItem>> GetItemsAsync()
        {
            return database.Table<TodoItem>().ToListAsync();
        }

        public Task<List<TodoItem>> GetItemsNotDoneAsync(string query)
        {
            return database.QueryAsync<TodoItem>(query);
        }

        public Task<TodoItem> GetItemAsync(int id)
        {
            return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TodoItem item)
        {
            return database.DeleteAsync(item);
        }
        #endregion Methods
    }
}
