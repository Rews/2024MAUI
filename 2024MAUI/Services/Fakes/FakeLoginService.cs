using _2024MAUI.Services.DTOs;

namespace _2024MAUI.Services.Fakes;

public class FakeLoginService : ILoginService
{
    public async Task<UserDTO> Login(LoginDTO loginDto)
    {
        await Task.Delay(2000);
        if (loginDto.Username == "123" && loginDto.Password == "123")
            return new UserDTO(){Name = "test"};
        throw new Exception("Неверный пользователь или пароль");
    }
}