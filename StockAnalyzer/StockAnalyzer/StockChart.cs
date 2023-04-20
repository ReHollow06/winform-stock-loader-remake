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
        Patterns highlightPattern;
        CandlestickReader csReader = null;
        Dictionary<Patterns, Recogniser> recognisers = new Dictionary<Patterns, Recogniser>();
        List<Candlestick> visibleCandlesticks;
        Dictionary<string, Patterns> visiblePatterns = new Dictionary<string, Patterns>();


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

            this.recognisers[Patterns.Doji] = new RecogniserDoji();
            this.recognisers[Patterns.Hammer_bullish] = new RecogniserBullishHammer();
            this.recognisers[Patterns.Hammer_bearish] = new RecogniserBearishHammer();
            this.recognisers[Patterns.Marubozu_bullish] = new RecogniserBullishMarubozu();
            this.recognisers[Patterns.Marubozu_bearish] = new RecogniserBearishMarubozu();
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
                visibleCandlesticks = csReader.populateChart(chartStockDisplayWindow); // populates chartStockDisplay with values from stock csv file
                foreach (var pattern in recognisers.Keys)
                {
                    if (recognisers[pattern].returnIndices(visibleCandlesticks).Count() != 0)
                    {
                        comboBoxPatternHighlighted.Items.Add(recognisers[pattern].patternName);
                        this.visiblePatterns[recognisers[pattern].patternName] = pattern;
                    }
                }

                this.highlightPattern = visiblePatterns.Values.ToArray()[0];
            }
        }

        /// <summary>
        /// Function used in paint event to draw box over certain points given an index
        /// </summary>
        /// <param name="points"></param>
        /// <param name="color"></param>
        /// <param name="e"></param>
        void highlightPoints(List<int> points, Pen color, PaintEventArgs e)
        {
            foreach (int point in points)
            {
                if (point >= 0 && point < chartStockDisplayWindow.Series[0].Points.Count)
                {
                    DataPoint dp = chartStockDisplayWindow.Series[0].Points[point];
                    float x = (float)chartStockDisplayWindow.ChartAreas[0].AxisX.ValueToPixelPosition(dp.XValue);
                    float y = (float)chartStockDisplayWindow.ChartAreas[0].AxisY.ValueToPixelPosition(dp.YValues[0]);

                    float boxWidth = 10f;
                    float boxHeight = 10f;
                    e.Graphics.DrawRectangle(color, x - boxWidth / 2, y - boxHeight / 2, boxWidth, boxHeight);
                }
            }
        }
        private void chartStockDisplayWindow_Paint(object sender, PaintEventArgs e)
        {
            List<int> points = new List<int>();
            Pen color = Pens.Black;
            switch (this.highlightPattern)
            {
                case Patterns.Doji:
                    points = recognisers[Patterns.Doji].returnIndices(visibleCandlesticks);
                    color = Pens.Black;
                    break;
                case Patterns.Marubozu_bearish:
                    points = recognisers[Patterns.Marubozu_bearish].returnIndices(visibleCandlesticks);
                    color = Pens.Blue;
                    break;
                case Patterns.Marubozu_bullish:
                    points = recognisers[Patterns.Marubozu_bullish].returnIndices(visibleCandlesticks);
                    color = Pens.Red;
                    break;
                case Patterns.Hammer_bullish:
                    points = recognisers[Patterns.Hammer_bullish].returnIndices(visibleCandlesticks); ;
                    color = Pens.Green;
                    break;
                case Patterns.Hammer_bearish:
                    points = recognisers[Patterns.Hammer_bearish].returnIndices(visibleCandlesticks);
                    color = Pens.Magenta;
                    break;
            }
            //List<int> points = this.csReader.dojiIndex();
            highlightPoints(points, color, e);
        }

        private void chartStockDisplayWindow_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPatternHighlighted_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.highlightPattern = visiblePatterns[comboBoxPatternHighlighted.Text];
            this.Invalidate();
            this.Update();
            this.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
