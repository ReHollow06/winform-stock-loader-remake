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
            StreamReader fileReader = null;
            try
            {
                fileReader = new StreamReader(stockFile.FullName);
            }
            catch (Exception)
            {
                fileReader = null;
            }

            if (fileReader != null)
            {
                using (fileReader)
                {
                    using (var csv = new CsvReader(fileReader, CultureInfo.InvariantCulture))
                    {
                        candlesticks = csv.GetRecords<Candlestick>().ToList();
                    }
                } 
            }
        }

        /// <summary>
        /// Populates a data table with data from candlesticks list
        /// </summary>
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

        /// <summary>
        /// Populates a chart with data from candlesticks list
        /// </summary>
        public void populateChart(Chart chart)
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

            chart.Series.Clear();
            Series series = chart.Series.Add("Candlestick");
            series.CustomProperties = "PriceDownColor=red,PriceUpColor=green";
            series.ChartType = SeriesChartType.Candlestick;
            series.XValueType = ChartValueType.Date;

            foreach (Candlestick d in dataSource)
            {
                DataPoint dp = new DataPoint();
                dp.SetValueXY(d.Date, d.High, d.Low, d.Open, d.Close);
                series.Points.Add(dp);
            }

            chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }

        /// <summary>
        /// Returns a list of integers corresponding to indices in the candlestick list which fit the criteria of a doji candlestick
        /// </summary>
        /// <returns></returns>
        public List<int> dojiIndex()
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < this.candlesticks.Count; i++)
            {
                var cs = candlesticks[i];
                Decimal bodyLength = Math.Abs(cs.Open - cs.Close);

                Decimal range = Math.Abs(cs.High - cs.Low);

                Decimal bodyRatio = bodyLength/ range;

                if (bodyRatio < 0.01m)
                {
                    indices.Add(i);
                }
                else
                {
                    continue;
                }
            }

            return indices;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }

        public DateTime returnEndDate()
        {
            return this.endDate;
        }
    }
}
