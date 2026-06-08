using GorevApp.Hizmet;
using Microsoft.Extensions.Logging;

namespace GorevApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Veritabanı Servisini Kaydet (Singleton: Uygulama boyunca tek bir kopya)
            builder.Services.AddSingleton<TodoDatabase>();

            // Sayfaları Kaydet (Transient: Her çağrıldığında yeni bir kopya)
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<TaskEditPage>();
            // -------------------
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
