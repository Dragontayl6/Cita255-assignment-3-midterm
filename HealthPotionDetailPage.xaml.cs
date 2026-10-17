namespace PixelPantry;

public partial class HealthPotionDetailPage : ContentPage
{
    public HealthPotionDetailPage()
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
            // Add to cart
            const string name = "Health Potion Gummies";
            const decimal price = 6.99m;

            Cart.Names.Add(name);
            Cart.Prices.Add(price);
            Cart.Quantities.Add(quantity);

            messageLabel.Text = $"{quantity} {name} added to cart!";
            messageLabel.TextColor = Colors.MediumSpringGreen;
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
