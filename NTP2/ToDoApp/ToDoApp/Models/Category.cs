using SQLite;

namespace ToDoApp.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
    }
}
