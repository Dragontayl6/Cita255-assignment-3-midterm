namespace PixelPantry;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(HealthPotionDetailPage),
            typeof(HealthPotionDetailPage));

        Routing.RegisterRoute(
            nameof(ManaPotionDetailPage),
            typeof(ManaPotionDetailPage));

        Routing.RegisterRoute(
            nameof(CookieDetailPage),
            typeof(CookieDetailPage));

        Routing.RegisterRoute(
            nameof(GoldenCoinDetailPage),
            typeof(GoldenCoinDetailPage));
    }
}