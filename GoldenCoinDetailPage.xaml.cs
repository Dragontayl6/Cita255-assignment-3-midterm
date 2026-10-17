namespace PixelPantry;

public partial class GoldenCoinDetailPage : ContentPage
{
    public GoldenCoinDetailPage()
    {
        InitializeComponent();
    }

    private void AddToCart_Clicked(
        object sender,
        EventArgs e)
    {
        if (int.TryParse(quantityEntry.Text, out int quantity)
            && quantity > 0)
        {
            const string name = "Golden Coin Chocolates";
            const decimal price = 7.49m;

            Cart.Names.Add(name);
            Cart.Prices.Add(price);
            Cart.Quantities.Add(quantity);

            messageLabel.Text =
                $"{quantity} {name} added to cart!";

            messageLabel.TextColor =
                Colors.MediumSpringGreen;
        }
        else
        {
            messageLabel.Text =
                "Please enter a valid quantity.";

            messageLabel.TextColor =
                Colors.PaleGoldenrod;
        }
    }
}