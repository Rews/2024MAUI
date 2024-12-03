using System.Collections.ObjectModel;

namespace _2024MAUI.ViewModel;

public class NextPageVM
{
    public ObservableCollection<ItemVM> Items { get; set; }

    public NextPageVM()
    {
        Items = new ObservableCollection<ItemVM>();

        LoadNews();
    }

    private async  void LoadNews()
    {
        //TODO: Загрузка новостей с сервера

        try
        {
            var newsItems = await Context.NewsService.GetNewsAsync();

            foreach (var news in newsItems)
            {
                Items.Add(new ItemVM(){Title = news.Title, Description = news.Description});
            }
        }
        catch (Exception e)
        {
            //TODOD: ShowDialog(Messge + ex.ToString())
            Console.WriteLine(e);
            throw;
        }
    }
}