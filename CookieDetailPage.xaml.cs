namespace PixelPantry;

public partial class CookieDetailPage : ContentPage
{
    public CookieDetailPage()
    {
        InitializeComponent();
    }

    private void AddToCart_Clicked(
        object sender,
        EventArgs e)
    {
        // Product is out of stock; do not add to cart.
        messageLabel.Text = "This product is currently out of stock.";
        messageLabel.TextColor = Colors.PaleGoldenrod;
    }
}