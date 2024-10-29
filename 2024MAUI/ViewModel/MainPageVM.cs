using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace _2024MAUI.ViewModel;

public class MainPageVM : INotifyPropertyChanged
{
    private string _login;
    public string Login{    
        get => _login;
        set
        {
            if(value == _login) return;
            _login = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Login)));
        }
    }

    
    public string Password { set; get; }
    public ICommand LoginButton { get; set; }

    private IMainPage _mainPage;
    public MainPageVM(IMainPage mainPage)
    {
        _mainPage = mainPage;
        LoginButton = new Command(Authorize);
    }

    private void Authorize()
    {
        //TODO: реализация авторизации

        this.Login = "";
        this.Password = "";
        
        //_mainPage.ShowNextPage();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
