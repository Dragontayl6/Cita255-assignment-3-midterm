namespace PixelPantry;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
    }

    private async void HealthPotion_Tapped(
        object sender,
        TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(
            nameof(HealthPotionDetailPage));
    }

    private async void ManaPotion_Tapped(
        object sender,
        TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(
            nameof(ManaPotionDetailPage));
    }

    private async void Cookie_Tapped(
        object sender,
        TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(
            nameof(CookieDetailPage));
    }

    private async void GoldenCoin_Tapped(
        object sender,
        TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(
            nameof(GoldenCoinDetailPage));
    }

    private async void Checkout_Clicked(
        object sender,
        EventArgs e)
    {
        await Shell.Current.GoToAsync("//Checkout");
    }
}