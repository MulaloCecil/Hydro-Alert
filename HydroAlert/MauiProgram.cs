using HydroAlert.ViewModels;
using HydroAlert.Views;
using Microsoft.Extensions.Logging;

using SkiaSharp.Views.Maui.Controls.Hosting;
namespace HydroAlert
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();

            builder.Services.AddSingleton <LoginPageViewModel>();
#endif

            return builder.Build();
        }
    }
}
