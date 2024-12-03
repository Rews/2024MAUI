using _2024MAUI.Services.DTOs;
using Newtonsoft.Json;

namespace _2024MAUI.Services.Implementations;

public class NewsService : INewsService
{
    public async Task<List<NewsDTO>> GetNewsAsync()
    {
        var http = new HttpClient();
        var response = await http.GetAsync(new Uri("http://localhost:5054/api/news"));
        var str = await response.Content.ReadAsStringAsync();
        var news = JsonConvert.DeserializeObject<List<NewsDTO>>(str);
        
        return news!;
    }
}