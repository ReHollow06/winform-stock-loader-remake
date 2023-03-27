using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAnalyzer
{
    public partial class StockChart : Form
    {
        string dataFolder;
        string tickerName;
        string timePeriod;
        DateTime startDate;
        DateTime endDate;
        string filePath;
        FileInfo file = null;

        public StockChart(string dataFolder, string tickerName, string timePeriod, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.dataFolder = dataFolder;
            this.tickerName = tickerName.ToUpper();
            this.timePeriod = timePeriod;
            this.startDate = startDate;
            this.endDate = endDate;

            filePath = dataFolder + @"\" + tickerName + "-" + timePeriod + ".csv"; // Path to csv file
            try
            {
                this.file = new FileInfo(filePath); // FileInfo object to csv file
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ticker name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.file = null;
            }
        }

        private void StockChart_Load(object sender, EventArgs e)
        {
            if (endDate <= startDate)
            {
                MessageBox.Show("End date behind start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.file != null)
            {
                CandlestickReader reader = new CandlestickReader(startDate, endDate, filePath); // instantiates candlestick reader object
                reader.populateChart(chartStockDisplayWindow); // populates chartStockDisplay with values from stock csv file

            }
        }
    }
}
