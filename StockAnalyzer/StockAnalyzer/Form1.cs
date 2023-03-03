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
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Windows.Forms.DataVisualization.Charting;


namespace StockAnalyzer
{
    public partial class Form1 : Form
    {

        DataTable stockValues = new DataTable(); // datatable to hold stock value for display
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string dataFolder = "Stock Data"; // Folder containing stock data
            string timePeriod = "Day"; // selected time period
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;


            if (radioButtonDaily.Checked)
            {
                timePeriod = "Day";
            }
            else if (radioButtonWeekly.Checked)
            {
                timePeriod = "Week";
            }
            else if (radioButtonMonthly.Checked)
            {
                timePeriod = "Month";
            }

            string fileName = textBoxTickerSelect.Text.ToUpper(); // gets text from textbox for ticker

            try
            {
                string filePath = dataFolder + @"\" + textBoxTickerSelect.Text + "-" + timePeriod + ".csv"; // Path to csv file
                var file = new FileInfo(filePath); // FileInfo object to csv file

                
                string[] lines = File.ReadAllLines(filePath);

                if (lines[0].ToLower() == "\"date\",\"open\",\"high\",\"low\",\"close\",\"volume\"") // initialise columns
                {
                    
                    stockValues.Rows.Clear();
                    stockValues.Columns.Clear();
                    stockValues.Columns.Add("Date");
                    stockValues.Columns.Add("Open");
                    stockValues.Columns.Add("High");
                    stockValues.Columns.Add("Low");
                    stockValues.Columns.Add("Close");
                    stockValues.Columns.Add("Volume");
                }

                if (endDate <= startDate)
                {
                    MessageBox.Show("End date behind start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stockValues.Rows.Clear();
                }
                else
                {
                    CandlestickReader reader = new CandlestickReader(startDate, endDate, filePath); // instantiates candlestick reader object
                    reader.populateDataTable(stockValues); // populates data table Stock Values with values from stock csv file
                    reader.populateChart(chartStockDisplay); // populates chartStockDisplay with values from stock csv file
                }
                dataGridViewStockDisplay.DataSource = stockValues;
            }
            catch (Exception) // Shows error message if ticker text box contains invalid ticker name
            {
                MessageBox.Show("Invalid ticker name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

}

        private void radioButtonChooseChart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonChooseGridView_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chartStockDisplay_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTickerSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {

        }

        public long countLines(FileInfo file) /// Reads in a FileInfo object and returns the number of lines in the file
        {
            long lineCount = 0;
            using (StreamReader reader = new StreamReader(file.FullName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {

        }
    }
}
