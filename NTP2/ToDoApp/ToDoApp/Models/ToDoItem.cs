using SQLite;

namespace ToDoApp.Models
{
    public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? FinishedDate { get; set; }

        [Indexed]
        public int CategoryId { get; set; }

        [Ignore]
        public string CategoryName { get; set; } = string.Empty;
    }
}
