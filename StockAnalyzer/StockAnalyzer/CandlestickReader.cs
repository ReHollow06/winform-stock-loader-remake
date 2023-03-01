using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace StockAnalyzer
{
    internal class CandlestickReader
    {
        DateTime startDate; // starting date from
        DateTime endDate;
        FileInfo stockFile;
        List<Candlestick> candlesticks;
        public CandlestickReader(DateTime startDate, DateTime endDate, string filePath)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.stockFile = new FileInfo(filePath);

            using (var reader = new StreamReader(stockFile.FullName))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    candlesticks = csv.GetRecords<Candlestick>().ToList();
                }
            }
        }

        public void populateDataTable(DataTable dataTable)
        {
            foreach (var candlestick in candlesticks)
            {  // reads through lines from 
                var date = candlestick.Date;
                if (date >= startDate && date <= endDate)
                {
                    dataTable.Rows.Add(candlestick.Date, candlestick.Open, candlestick.High, candlestick.Low, candlestick.Close, candlestick.Volume);
                }
            }
        }
    }
}
