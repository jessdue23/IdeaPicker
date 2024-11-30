using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class AddPlace : ContentPage
{
    public AddPlace()
    {
        InitializeComponent();
        Title = "Add New Place";
    }

    private void AddRestaurant_OnClicked(object sender, EventArgs e)
    {
        var newRestaurant = new Restaurant();
        newRestaurant.Name = txtRestaurantName.Text;
        
        App.RestaurantList.SaveRestaurant(newRestaurant);

        txtRestaurantName.Text = "";
    }
}