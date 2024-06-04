using Microsoft.Extensions.Logging;
using SOSU_Power_9000.CareApp.ViewModels;
using SOSU_Power_9000.Services;

namespace SOSU_Power_9000.CareApp
{
    public static class MauiProgram
    {
        private const string url = "https://localhost:7033/";

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

            Uri baseUri = new Uri(url);
            builder.Services.AddScoped<ISosuService>(x => new SosuService(baseUri));
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
