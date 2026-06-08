using GorevApp.Model;
using SQLite;

namespace GorevApp.Hizmet
{
    public class TodoDatabase
    {
        SQLiteAsyncConnection Database;

        async Task Init()
        {
            if (Database is not null) return;

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "TodoSqlite.db3");
            Database = new SQLiteAsyncConnection(dbPath);
            await Database.CreateTableAsync<TodoItem>();
        }

        public async Task<List<TodoItem>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<TodoItem>().ToListAsync();
        }

        public async Task<List<TodoItem>> GetCompletedItemsAsync()
        {
            await Init();
            var liste = await Database.Table<TodoItem>().ToListAsync();
            var tamamlananlar = liste.Where(x => x.IsCompleted).ToList();
            return tamamlananlar;
        }


        public async Task<int> SaveItemAsync(TodoItem item)
        {
            await Init();
            if (item.Id != 0)
                return await Database.UpdateAsync(item);
            else
                return await Database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(TodoItem item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }
    }
}
