using _2024MAUI.Services.DTOs;

namespace _2024MAUI.Services;

public interface ILoginService
{
    public Task<UserDTO> Login(LoginDTO loginDto);
}