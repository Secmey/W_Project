using Microsoft.Extensions.Logging;
using W_Project.Pages;
using W_Project.Pages.Services;

namespace W_Project
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

            // AddTransient wird verwendet, um Services mit der konkreten Implementierung ein Service zu registrieren.
            // Mit AddTransient wird jedes Mal, wenn ein Service benötigt wird, eine neue Instanz vom Service erstellt.
            // Dies ist ideal für leichte, zustandslose Dienste.
            builder.Services.AddTransient<IsAuthenticated>();
            builder.Services.AddTransient<LoadingPage>();
            builder.Services.AddTransient<ListingPage>();
            builder.Services.AddTransient<Contents>();


            return builder.Build();
        }
    }
}