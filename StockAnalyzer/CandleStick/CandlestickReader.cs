using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandleStick
{
    internal class CandlestickReader
    {
        const string dataFolder = "Stock Data";
        public List<Candlestick> candlesticks;

        public CandlestickReader()
        {
            candlesticks = new List<Candlestick>(256);
        }

        public List<Candlestick> readCandlesticks(string csvFilename, DateTime start, DateTime end)
        {
            return null;
        }
    }
}
