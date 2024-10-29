using _2024MAUI.Services;

namespace _2024MAUI;

public static class Context
{
    public static ILoginService LoginService => Service<ILoginService>.GetInstance();
    public static INewsService NewsService => Service<INewsService>.GetInstance();
}