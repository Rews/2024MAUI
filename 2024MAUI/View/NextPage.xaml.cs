using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2024MAUI.ViewModel;

namespace _2024MAUI;

public partial class NextPage : ContentPage
{
    public NextPage()
    {
        InitializeComponent();
        this.BindingContext = new NextPageVM();
    }
}