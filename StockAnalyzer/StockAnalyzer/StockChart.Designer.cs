namespace StockAnalyzer
{
    partial class StockChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStockDisplayWindow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplayWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStockDisplayWindow
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockDisplayWindow.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStockDisplayWindow.Legends.Add(legend1);
            this.chartStockDisplayWindow.Location = new System.Drawing.Point(50, 9);
            this.chartStockDisplayWindow.Name = "chartStockDisplayWindow";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartStockDisplayWindow.Series.Add(series1);
            this.chartStockDisplayWindow.Size = new System.Drawing.Size(700, 432);
            this.chartStockDisplayWindow.TabIndex = 1;
            this.chartStockDisplayWindow.Text = "chartStockDisplayWindow";
            // 
            // StockChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartStockDisplayWindow);
            this.Name = "StockChart";
            this.Text = "StockChart";
            this.Load += new System.EventHandler(this.StockChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplayWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockDisplayWindow;
    }
}