using _2024MAUI.ViewModel;

namespace _2024MAUI;

public partial class MainPage : ContentPage, IMainPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        var mainPageVM = new MainPageVM(this);

        this.BindingContext = mainPageVM;

    }

    public void ShowNextPage()
    {
        this.Navigation.PushAsync(new NextPage());
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        // MyLabel.Text = MyEditor.Text;
        // MyEditor.Text = "";

        // count++;
        //
        // if (count == 1)
        //     CounterBtn.Text = $"Clicked {count} time";
        // else
        //     CounterBtn.Text = $"Clicked {count} times";
    }
}