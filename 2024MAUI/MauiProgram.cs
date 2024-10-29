using _2024MAUI.Services;
using _2024MAUI.Services.Fakes;
using _2024MAUI.Services.Implementations;
using Microsoft.Extensions.Logging;

namespace _2024MAUI;

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

        var fake = true;

        if (fake)
        {
           // ServiceLocator.RegisterService(typeof(ILoginService), new FakeLoginService());
           Service<ILoginService>.RegisterService(new FakeLoginService());
           Service<INewsService>.RegisterService(new FakeNewsService());
        }
        else
        {
            //ServiceLocator.RegisterService(typeof(ILoginService), new LoginService());
            Service<ILoginService>.RegisterService(new LoginService());
            Service<INewsService>.RegisterService(new NewsService());
        }

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}