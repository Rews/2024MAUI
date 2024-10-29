using _2024MAUI.Services.DTOs;

namespace _2024MAUI.Services;

public interface INewsService
{
    public Task<List<NewsDTO>> GetNewsAsync();
}