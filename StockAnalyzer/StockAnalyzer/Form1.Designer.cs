namespace StockAnalyzer
{
    partial class Form1
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
            this.chartStockDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.dataGridViewStockDisplay = new System.Windows.Forms.DataGridView();
            this.labelTickerSelect = new System.Windows.Forms.Label();
            this.textBoxTickerSelect = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplay)).BeginInit();
            this.groupBoxPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStockDisplay
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockDisplay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStockDisplay.Legends.Add(legend1);
            this.chartStockDisplay.Location = new System.Drawing.Point(345, 306);
            this.chartStockDisplay.Name = "chartStockDisplay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chartStockDisplay.Series.Add(series1);
            this.chartStockDisplay.Size = new System.Drawing.Size(700, 432);
            this.chartStockDisplay.TabIndex = 0;
            this.chartStockDisplay.Text = "chartStockDisplay";
            this.chartStockDisplay.Click += new System.EventHandler(this.chartStockDisplay_Click);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxPeriod.Location = new System.Drawing.Point(12, 388);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(121, 113);
            this.groupBoxPeriod.TabIndex = 1;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(6, 74);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(74, 20);
            this.radioButtonMonthly.TabIndex = 2;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(6, 48);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(74, 20);
            this.radioButtonWeekly.TabIndex = 1;
            this.radioButtonWeekly.TabStop = true;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Checked = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(7, 22);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(59, 20);
            this.radioButtonDaily.TabIndex = 0;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.radioButtonDaily_CheckedChanged);
            // 
            // dataGridViewStockDisplay
            // 
            this.dataGridViewStockDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockDisplay.Location = new System.Drawing.Point(33, 12);
            this.dataGridViewStockDisplay.Name = "dataGridViewStockDisplay";
            this.dataGridViewStockDisplay.RowHeadersWidth = 51;
            this.dataGridViewStockDisplay.RowTemplate.Height = 24;
            this.dataGridViewStockDisplay.Size = new System.Drawing.Size(1012, 288);
            this.dataGridViewStockDisplay.TabIndex = 3;
            // 
            // labelTickerSelect
            // 
            this.labelTickerSelect.AutoSize = true;
            this.labelTickerSelect.Location = new System.Drawing.Point(12, 356);
            this.labelTickerSelect.Name = "labelTickerSelect";
            this.labelTickerSelect.Size = new System.Drawing.Size(51, 16);
            this.labelTickerSelect.TabIndex = 4;
            this.labelTickerSelect.Text = "Ticker :";
            // 
            // textBoxTickerSelect
            // 
            this.textBoxTickerSelect.Location = new System.Drawing.Point(69, 353);
            this.textBoxTickerSelect.Name = "textBoxTickerSelect";
            this.textBoxTickerSelect.Size = new System.Drawing.Size(121, 22);
            this.textBoxTickerSelect.TabIndex = 5;
            this.textBoxTickerSelect.TextChanged += new System.EventHandler(this.textBoxTickerSelect_TextChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(18, 610);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(164, 78);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(99, 518);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerStartDate.TabIndex = 7;
            this.dateTimePickerStartDate.Value = new System.DateTime(2022, 1, 1, 14, 51, 0, 0);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(12, 523);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(69, 16);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(15, 558);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(69, 16);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End Date: ";
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(99, 553);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerEndDate.TabIndex = 10;
            this.dateTimePickerEndDate.Value = new System.DateTime(2022, 1, 29, 14, 51, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 750);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxTickerSelect);
            this.Controls.Add(this.labelTickerSelect);
            this.Controls.Add(this.dataGridViewStockDisplay);
            this.Controls.Add(this.groupBoxPeriod);
            this.Controls.Add(this.chartStockDisplay);
            this.Name = "Form1";
            this.Text = "Stock Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplay)).EndInit();
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockDisplay;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.DataGridView dataGridViewStockDisplay;
        private System.Windows.Forms.Label labelTickerSelect;
        private System.Windows.Forms.TextBox textBoxTickerSelect;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}

