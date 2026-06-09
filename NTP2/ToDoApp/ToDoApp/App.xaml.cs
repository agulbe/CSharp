using Microsoft.Extensions.DependencyInjection;

namespace ToDoApp
{
    public partial class App : Application
    {
        [Obsolete]
        public App(MainPage mainPage)
        {
            InitializeComponent();
            MainPage = new NavigationPage(mainPage);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}