using IdeaPicker.Models;

namespace IdeaPicker;

public partial class App : Application
{
    public static Repository RestaurantList;
    public App()
    {
        InitializeComponent();
        RestaurantList = new Repository();
        MainPage = new AppShell();
    }
}