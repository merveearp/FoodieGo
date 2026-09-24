using FoodieGo.Models;
using FoodieGo.Services;

namespace FoodieGo.Pages;

public partial class DiscountsPage : ContentPage
{
    private readonly DatabaseService _databaseService = new DatabaseService();

    public DiscountsPage()
	{
		InitializeComponent();
	}

    // Sayfa her açıldığında çalışır
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Veritabanından indirimleri çek ve kapsayıcıya ver
        BannerContainer.BindingContext = await _databaseService.GetDiscountsAsync();
    }




}