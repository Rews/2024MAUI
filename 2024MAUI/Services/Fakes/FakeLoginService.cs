namespace _2024MAUI.Services.Fakes;

public class FakeLoginService : ILoginService
{
    public async Task<bool> Login(string username, string password)
    {
        await Task.Delay(2000);
        if (username == "123" && password == "123")
            return true;
        return false;
    }
}