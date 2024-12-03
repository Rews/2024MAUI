using System.Text;
using _2024MAUI.Services.DTOs;
using Newtonsoft.Json;

namespace _2024MAUI.Services.Implementations;

public class LoginService : ILoginService
{
    public async Task<UserDTO> Login(LoginDTO loginDto)
    {
        var http = new HttpClient();
        var json = JsonConvert.SerializeObject(loginDto);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await http.PostAsync(new Uri("http://localhost:5054/api/login"), content);
        var str = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<UserDTO>(str);
        return result!;
    }
}