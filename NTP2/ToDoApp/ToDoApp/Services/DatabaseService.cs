
using SQLite;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Category>().Wait();
            _database.CreateTableAsync<ToDoItem>().Wait();
        }

        // === CATEGORY ===
        public Task<List<Category>> GetCategoriesAsync() =>
            _database.Table<Category>().ToListAsync();

        public Task<int> SaveCategoryAsync(Category category) =>
            category.CategoryId == 0
                ? _database.InsertAsync(category)
                : _database.UpdateAsync(category);

        public Task<int> DeleteCategoryAsync(Category category) =>
            _database.DeleteAsync(category);

        // === TODO ITEMS ===
        public async Task<List<ToDoItem>> GetToDoItemsAsync(int? categoryId = null)
        {
            var query = _database.Table<ToDoItem>();

            if (categoryId.HasValue)
                query = query.Where(t => t.CategoryId == categoryId.Value);

            var items = await query.ToListAsync();
            var categories = await GetCategoriesAsync();

            foreach (var item in items)
            {
                var cat = categories.FirstOrDefault(c => c.CategoryId == item.CategoryId);
                item.CategoryName = cat?.Name ?? "Bilinmiyor";
            }

            return items;
        }

        public Task<List<ToDoItem>> GetOverdueItemsAsync() =>
            _database.Table<ToDoItem>()
                .Where(t => !t.IsFinished && t.DueDate < DateTime.Now)
                .ToListAsync();

        public Task<List<ToDoItem>> GetCompletedItemsAsync() =>
            _database.Table<ToDoItem>()
                .Where(t => t.IsFinished)
                .ToListAsync();

        public Task<int> SaveToDoItemAsync(ToDoItem item)
        {
            if (item.IsFinished && !item.FinishedDate.HasValue)
                item.FinishedDate = DateTime.Now;
            else if (!item.IsFinished)
                item.FinishedDate = null;

            return item.Id == 0
                ? _database.InsertAsync(item)
                : _database.UpdateAsync(item);
        }

        public Task<int> DeleteToDoItemAsync(ToDoItem item) =>
            _database.DeleteAsync(item);
    }
}
