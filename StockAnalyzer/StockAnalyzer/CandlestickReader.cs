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

        public CandlestickReader(DateTime startDate, DateTime endDate, string filePath)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.stockFile = new FileInfo(filePath);
        }
        public void populateDataTable(DataTable dataTable)
        {
            using (var reader = new StreamReader(stockFile.FullName)) // using csvhelper to process stock csv file
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Candlestick>().ToList(); // stores data for each line in csv as a list
                    foreach (var record in records) // reads through lines from 
                    {
                        var date = record.Date;
                        if (date >= startDate && date <= endDate)
                        {
                            dataTable.Rows.Add(record.Date, record.Open, record.High, record.Low, record.Close, record.Volume);
                        }
                    }
                }

            }
        }
    }
}
