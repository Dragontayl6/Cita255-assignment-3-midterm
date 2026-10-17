using System.Collections.Generic;

namespace PixelPantry;

public static class Cart
{
    // Three public static lists as required
    public static List<string> Names { get; } = new List<string>();
    public static List<decimal> Prices { get; } = new List<decimal>();
    public static List<int> Quantities { get; } = new List<int>();

    public static void Clear()
    {
        Names.Clear();
        Prices.Clear();
        Quantities.Clear();
    }
}
