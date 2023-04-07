using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Candlestick // class for representing a candlestick data point
{
    public DateTime Date { get; set; }
    public Decimal Open { get; set; }
    public Decimal High { get; set; }
    public Decimal Low { get; set; }
    public Decimal Close { get; set; }
    public long Volume { get; set; }

    public Candlestick(Decimal open, Decimal high, Decimal low, Decimal close, long Volume)
    {
        this.Open = open;
        this.High = high;
        this.Low = low;
        this.Close = close;
        this.Volume = Volume;
    }
}
