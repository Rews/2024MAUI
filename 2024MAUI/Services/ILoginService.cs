namespace _2024MAUI.Services;

public interface ILoginService
{
    public Task<bool> Login(string username, string password);
}