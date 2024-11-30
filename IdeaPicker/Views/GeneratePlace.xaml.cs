using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPicker.Views;

public partial class GeneratePlace : ContentPage
{
    public GeneratePlace()
    {
        InitializeComponent();
        Title = "View and Generate";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var restaurantTemplate = new DataTemplate(typeof(TextCell));
        restaurantTemplate.SetBinding(TextCell.TextProperty, "Name");

        lstRestaurants.ItemTemplate = restaurantTemplate;
        lstRestaurants.ItemsSource = App.RestaurantList.GetRestaurants();
    }

    private void Generate_OnClicked(object sender, EventArgs e)
    {
        Random rand = new Random();
        int r = rand.Next(App.RestaurantList.GetRestaurants().Count);
        var result = App.RestaurantList.GetRestaurants();
        string randomResult = result[r].Name.ToString();
        txtGeneratedRestaurant.Text = randomResult;
    }
}