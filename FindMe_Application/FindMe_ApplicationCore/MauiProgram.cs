using CommunityToolkit.Maui;

namespace FindMe_Application;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiCommunityToolkit()
            .UseMauiApp<App>();

        return builder.Build();
    }
}
