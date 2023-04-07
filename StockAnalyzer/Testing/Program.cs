// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool IsDoji(Candlestick cs)
{
    // Calculate the difference between open and close prices
    Decimal diff = Math.Abs(cs.Open - cs.Close);

    // Calculate the range between the high and low prices
    Decimal range = Math.Abs(cs.High - cs.Low);

    // Check if the difference between open and close is less than the threshold
    if (diff / range < 0.05m)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Candlestick cs = new Candlestick(314.15m, 316.5m, 310.09m, 314.04m, 32720018);

Console.WriteLine(IsDoji(cs));