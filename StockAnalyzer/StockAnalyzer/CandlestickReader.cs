using System;
using System.Collections;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace StockAnalyzer
{
    internal class CandlestickReader  // class for handling reading and processing candlestick data
    {
        DateTime startDate; // starting date from datetime selector
        DateTime endDate; // ending date from datetime selector
        FileInfo stockFile; // FileInfo object for csv stock file
        List<Candlestick> candlesticks; // list of candlesticks 
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

        public void populateDataTable(DataTable dataTable) // populates a data table with data from candlesticks list
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

        public void populateChart(Chart chart) // populates a chart with data from candlesticks list
        {
            ArrayList dataSource = new ArrayList();

            foreach (var candlestick in candlesticks)
            {
                var date = candlestick.Date;
                if (date >= startDate && date <= endDate)
                {
                    dataSource.Add(candlestick);
                }
            }

            chart.Series["Series1"].XValueMember = "Date";
            chart.Series["Series1"].XValueType = ChartValueType.Date;
            chart.Series["Series1"].YValueMembers = "Open, High, Low, Close";
            chart.Series["Series1"].CustomProperties = "PriceDownColor=red,PriceUpColor=green";
            chart.DataManipulator.IsStartFromFirst = true;
            chart.Series["Series1"]["ShowOpenClose"] = "Both";

            chart.DataSource = dataSource;
            chart.DataBind();
        }
    }
}
