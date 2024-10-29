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

    private void LoadNews()
    {
        //TODO: Загрузка новостей с сервера

        var dataSource = new List<ItemVM>();
        
        dataSource.Add(new ItemVM(){Title = "Первый", Description = "Это у нас первый элемент"});
        dataSource.Add(new ItemVM(){Title = "Второй", Description = "Это у нас Второй элемент"});
        dataSource.Add(new ItemVM(){Title = "Третий", Description = "Это у нас Третий элемент"});
        dataSource.Add(new ItemVM(){Title = "Четвертый", Description = "Это у нас Четвертый элемент"});
        
        
        Items = new ObservableCollection<ItemVM>(dataSource);
    }
}