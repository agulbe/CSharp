using GorevApp.Hizmet;
using GorevApp.Model;

namespace GorevApp
{
    public partial class TaskEditPage : ContentPage
    {
        private readonly TodoDatabase _database;
        public TodoItem Item { get; set; }

        // Constructor'da veritabanını DI ile alıyoruz
        public TaskEditPage(TodoDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        // Sayfaya veri göndermek için bu metodu kullanacağız
        public void SetItem(TodoItem item)
        {
            Item = item;
            TitleEntry.Text = Item.Title;
            CategoryPicker.SelectedItem = Item.Category;
            DueDatePicker.Date = Item.DueDate == default ? DateTime.Now : Item.DueDate;
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            Item.Title = TitleEntry.Text;
            Item.Category = CategoryPicker.SelectedItem?.ToString();
            Item.DueDate = (DateTime)DueDatePicker.Date;

            await _database.SaveItemAsync(Item);
            await Navigation.PopAsync(); // Kaydettikten sonra geri dön
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Hiçbir şey yapmadan geri dön
        }
    }
}