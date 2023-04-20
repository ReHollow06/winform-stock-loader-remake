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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStockDisplayWindow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPatternHighlighted = new System.Windows.Forms.ComboBox();
            this.labelPatternHighlighted = new System.Windows.Forms.Label();
            this.panelDojiColor = new System.Windows.Forms.Panel();
            this.labelDojiColor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMarubozuBearish = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplayWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStockDisplayWindow
            // 
            chartArea4.Name = "ChartArea1";
            this.chartStockDisplayWindow.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartStockDisplayWindow.Legends.Add(legend4);
            this.chartStockDisplayWindow.Location = new System.Drawing.Point(12, 12);
            this.chartStockDisplayWindow.Name = "chartStockDisplayWindow";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            this.chartStockDisplayWindow.Series.Add(series4);
            this.chartStockDisplayWindow.Size = new System.Drawing.Size(700, 432);
            this.chartStockDisplayWindow.TabIndex = 1;
            this.chartStockDisplayWindow.Text = "chartStockDisplayWindow";
            this.chartStockDisplayWindow.Click += new System.EventHandler(this.chartStockDisplayWindow_Click);
            this.chartStockDisplayWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.chartStockDisplayWindow_Paint);
            // 
            // comboBoxPatternHighlighted
            // 
            this.comboBoxPatternHighlighted.FormattingEnabled = true;
            this.comboBoxPatternHighlighted.Location = new System.Drawing.Point(721, 65);
            this.comboBoxPatternHighlighted.Name = "comboBoxPatternHighlighted";
            this.comboBoxPatternHighlighted.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPatternHighlighted.TabIndex = 2;
            this.comboBoxPatternHighlighted.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatternHighlighted_SelectedIndexChanged);
            // 
            // labelPatternHighlighted
            // 
            this.labelPatternHighlighted.AutoSize = true;
            this.labelPatternHighlighted.Location = new System.Drawing.Point(718, 46);
            this.labelPatternHighlighted.Name = "labelPatternHighlighted";
            this.labelPatternHighlighted.Size = new System.Drawing.Size(49, 16);
            this.labelPatternHighlighted.TabIndex = 3;
            this.labelPatternHighlighted.Text = "Pattern";
            // 
            // panelDojiColor
            // 
            this.panelDojiColor.BackColor = System.Drawing.Color.Black;
            this.panelDojiColor.Location = new System.Drawing.Point(731, 161);
            this.panelDojiColor.Name = "panelDojiColor";
            this.panelDojiColor.Size = new System.Drawing.Size(22, 22);
            this.panelDojiColor.TabIndex = 4;
            // 
            // labelDojiColor
            // 
            this.labelDojiColor.AutoSize = true;
            this.labelDojiColor.Location = new System.Drawing.Point(759, 167);
            this.labelDojiColor.Name = "labelDojiColor";
            this.labelDojiColor.Size = new System.Drawing.Size(31, 16);
            this.labelDojiColor.TabIndex = 5;
            this.labelDojiColor.Text = "Doji";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(731, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 22);
            this.panel1.TabIndex = 5;
            // 
            // labelMarubozuBearish
            // 
            this.labelMarubozuBearish.AutoSize = true;
            this.labelMarubozuBearish.Location = new System.Drawing.Point(759, 195);
            this.labelMarubozuBearish.Name = "labelMarubozuBearish";
            this.labelMarubozuBearish.Size = new System.Drawing.Size(115, 16);
            this.labelMarubozuBearish.TabIndex = 6;
            this.labelMarubozuBearish.Text = "Bearish Marubozu";
            this.labelMarubozuBearish.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(731, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 22);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bullish Marubozu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(731, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 22);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bullish Hammer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Magenta;
            this.panel4.Location = new System.Drawing.Point(731, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 22);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bearish Hammer";
            // 
            // StockChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelMarubozuBearish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDojiColor);
            this.Controls.Add(this.panelDojiColor);
            this.Controls.Add(this.labelPatternHighlighted);
            this.Controls.Add(this.comboBoxPatternHighlighted);
            this.Controls.Add(this.chartStockDisplayWindow);
            this.Name = "StockChart";
            this.Text = "StockChart";
            this.Load += new System.EventHandler(this.StockChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockDisplayWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockDisplayWindow;
        private System.Windows.Forms.ComboBox comboBoxPatternHighlighted;
        private System.Windows.Forms.Label labelPatternHighlighted;
        private System.Windows.Forms.Panel panelDojiColor;
        private System.Windows.Forms.Label labelDojiColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMarubozuBearish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}