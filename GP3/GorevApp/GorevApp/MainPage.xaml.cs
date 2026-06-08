using GorevApp.Hizmet;
using GorevApp.Model;

namespace GorevApp
{
    public partial class MainPage : ContentPage
    {
        private readonly TodoDatabase _database;
        private readonly IServiceProvider _serviceProvider;

        public MainPage(TodoDatabase database, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _database = database;
            _serviceProvider = serviceProvider;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // Verileri veritabanından çek
            TasksCollection.ItemsSource = await _database.GetItemsAsync();
        }

        // Yeni Görev Ekleme Butonu veya Sol Menüden Tetikleme
        // Yeni Görev Ekleme
        async void OnAddNewTaskClicked(object sender, EventArgs e)
        {
            //// Handler veya MauiContext null ise işlemi durdur
            //if (Handler?.MauiContext == null) return;

            //var editPage = Handler.MauiContext.Services.GetService<TaskEditPage>();

            //if (editPage is not null)
            //{
            //    editPage.SetItem(new TodoItem());
            //    await Navigation.PushAsync(editPage);
            //}

            // Sayfayı direkt servis sağlayıcıdan güvenli bir şekilde al
            var editPage = _serviceProvider.GetService<TaskEditPage>();

            if (editPage != null)
            {
                editPage.SetItem(new TodoItem());
                await Navigation.PushAsync(editPage);
            }
        }

        // Kaydırınca Düzenle
        // Düzenleme
        // Kaydırınca Düzenle
        async void OnEditInvoked(object sender, EventArgs e)
        {
            // SwipeItem üzerinden gelen veriyi al
            var item = (sender as SwipeItem)?.CommandParameter as TodoItem;

            if (item == null) return;

            // Servis sağlayıcıdan (ServiceProvider) sayfayı güvenli bir şekilde iste
            var editPage = _serviceProvider.GetService<TaskEditPage>();

            if (editPage != null)
            {
                // Mevcut görevi sayfaya yükle
                editPage.SetItem(item);
                await Navigation.PushAsync(editPage);
            }
        }

        [Obsolete]
        async void OnDeleteInvoked(object sender, EventArgs e)
        {
            bool confirm=false;
            // 'as' operatörü başarısız olursa null döner. 
            // ?. ise nesne null ise CommandParameter'a bakmadan durur.
            var swipeItem = sender as SwipeItem;
            var item = swipeItem?.CommandParameter as TodoItem;

            // Eğer item herhangi bir sebeple null geldiyse işlemi durdur (Savunmacı kodlama)
            if (item == null)
            {
                // Doğrudan sayfa içindeki kullanımı (Güncel)
                
                confirm = await Shell.Current.DisplayAlert("Sil", "Emin misiniz?", "Evet", "Hayır");
                return;
            }

            confirm = await Shell.Current.DisplayAlert("Sil", $"'{item.Title}' görevini silmek istediğinize emin misiniz?", "Evet", "Hayır");

            if (confirm)
            {
                await _database.DeleteItemAsync(item);

                // Listeyi anlık olarak güncellemek için veritabanından tekrar çekiyoruz
                TasksCollection.ItemsSource = await _database.GetItemsAsync();
            }
        }
    }
}
