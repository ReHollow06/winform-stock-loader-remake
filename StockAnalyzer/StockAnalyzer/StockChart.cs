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
using System.Windows.Forms.DataVisualization.Charting;

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
        Form parentForm = null;
        CandlestickReader csReader = null;

        public StockChart(string dataFolder, string tickerName, string timePeriod, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.dataFolder = dataFolder;
            this.tickerName = tickerName;
            this.timePeriod = timePeriod;
            this.startDate = startDate;
            this.endDate = endDate;

            filePath = dataFolder + @"\" + tickerName; // Path to csv file
            try
            {
                this.file = new FileInfo(filePath); // FileInfo object to csv file
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ticker name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.file = null;
            }
            this.csReader = new CandlestickReader(startDate, endDate, filePath);
        }

        /// <summary>
        /// Returns file path to csv file being read
        /// </summary>
        /// <returns></returns>
        public string getFilePath()
        {
            return this.filePath;
        }

        /// <summary>
        /// Returns chartStockDisplayWindow
        /// </summary>
        /// <returns></returns>
        public Chart getChartStockDisplay()
        {
            return this.chartStockDisplayWindow;
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

        void highlightPoints(List<int> points, PaintEventArgs e)
        {
            foreach (int point in points)
            {
                if (point >=0 && point < chartStockDisplayWindow.Series[0].Points.Count)
                {
                    DataPoint dp = chartStockDisplayWindow.Series[0].Points[point];
                    float x = (float)chartStockDisplayWindow.ChartAreas[0].AxisX.ValueToPixelPosition(dp.XValue);
                    float y = (float)chartStockDisplayWindow.ChartAreas[0].AxisY.ValueToPixelPosition(dp.YValues[0]);

                    float boxWidth = 10f;
                    float boxHeight = 10f;
                    e.Graphics.DrawRectangle(Pens.Black, x - boxWidth / 2, y - boxHeight / 2, boxWidth, boxHeight);
                }
            }
        }
        private void chartStockDisplayWindow_Paint(object sender, PaintEventArgs e)
        {
            List<int> points = this.csReader.dojiIndex();
            highlightPoints(points, e);
        }

        private void chartStockDisplayWindow_Click(object sender, EventArgs e)
        {

        }
    }


}
