using GorevApp.Model;
namespace GorevApp
{
    public partial class AppShell : Shell
    {

        // Komutu tanımlıyoruz
        public Command AddNewTaskCommand { get; }

        public AppShell()
        {
            InitializeComponent();
            // Rotaları manuel kaydederek DI (Dependency Injection) desteğini sağla
            Routing.RegisterRoute(nameof(TaskEditPage), typeof(TaskEditPage));

            // Komutun ne yapacağını belirliyoruz
            AddNewTaskCommand = new Command(async () => await OnAddNewTask());

            // XAML tarafının bu komutu görebilmesi için BindingContext'i kendisi yapıyoruz
            BindingContext = this;
        }

        private async Task OnAddNewTask()
        {
            // Sayfayı servis sağlayıcı üzerinden güvenli bir şekilde alıyoruz
            // App.Current üzerinden servis sağlayıcıya erişebiliriz
            var services = Handler?.MauiContext?.Services;
            var editPage = services?.GetService<TaskEditPage>();

            if (editPage != null)
            {
                editPage.SetItem(new TodoItem { DueDate = DateTime.Now });
                await Navigation.PushAsync(editPage);

                // Menüyü (Flyout) otomatik kapat
                FlyoutIsPresented = false;
            }
        }

    }
}
