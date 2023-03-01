using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandleStick
{
    internal class Candlestick
    {
        public DateTime date { get; set; } 
        public Decimal priceOpen { get; set; }
        public Decimal priceHigh { get; set; }
        public Decimal priceLow { get; set; }
        public Decimal priceClose { get; set; }
        public long volume { get; set; }


        public Candlestick() { }
        public Candlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, long volume)
        {
            this.date = date;
            this.priceOpen = open;
            this.priceHigh = high;
            this.priceLow = low;
            this.priceClose = close;
            this.volume = volume;
        }
    }
}
