namespace PixelPantry;

public partial class CheckoutPage : ContentPage
{
    public CheckoutPage()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Build a display list of "{quantity} × {name} ($price each)"
        var items = new List<string>();
        for (int i = 0; i < Cart.Names.Count; i++)
        {
            var name = Cart.Names[i];
            var qty = Cart.Quantities[i];
            var price = Cart.Prices[i];
            items.Add($"{qty} × {name} (${price:F2} each)");
        }

        CartItemsCollection.ItemsSource = items;

        decimal total = 0m;
        for (int i = 0; i < Cart.Names.Count; i++)
        {
            total += Cart.Prices[i] * Cart.Quantities[i];
        }

        TotalLabel.Text = $"Total: ${total:F2}";
    }

    private async void CheckoutButton_Clicked(object sender, EventArgs e)
    {
        // Show total and clear cart
        decimal total = 0m;
        for (int i = 0; i < Cart.Names.Count; i++)
            total += Cart.Prices[i] * Cart.Quantities[i];

        if (Cart.Names.Count == 0)
        {
            await DisplayAlert("Checkout", "Your cart is empty.", "OK");
            return;
        }

        Cart.Clear();
        CartItemsCollection.ItemsSource = null;
        TotalLabel.Text = "Total: $0.00";

        await DisplayAlert("Order placed", $"Thanks for your order! Total: ${total:F2}", "OK");
    }
}