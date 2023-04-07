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
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.labelTickerSelect = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTickerSelect = new System.Windows.Forms.ComboBox();
            this.groupBoxPatterns = new System.Windows.Forms.GroupBox();
            this.radioButtonMarubozuBullish = new System.Windows.Forms.RadioButton();
            this.radioButtonDoji = new System.Windows.Forms.RadioButton();
            this.radioButtonMarubozuBearish = new System.Windows.Forms.RadioButton();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxPatterns.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxPeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxPeriod.Location = new System.Drawing.Point(193, 43);
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
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
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
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.radioButtonWeekly_CheckedChanged);
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
            // labelTickerSelect
            // 
            this.labelTickerSelect.AutoSize = true;
            this.labelTickerSelect.Location = new System.Drawing.Point(9, 91);
            this.labelTickerSelect.Name = "labelTickerSelect";
            this.labelTickerSelect.Size = new System.Drawing.Size(51, 16);
            this.labelTickerSelect.TabIndex = 4;
            this.labelTickerSelect.Text = "Ticker :";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 271);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(164, 78);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(99, 183);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerStartDate.TabIndex = 7;
            this.dateTimePickerStartDate.Value = new System.DateTime(2022, 1, 1, 14, 51, 0, 0);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(12, 188);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(69, 16);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(12, 229);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(69, 16);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End Date: ";
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(99, 224);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePickerEndDate.TabIndex = 10;
            this.dateTimePickerEndDate.Value = new System.DateTime(2022, 1, 29, 14, 51, 0, 0);
            // 
            // comboBoxTickerSelect
            // 
            this.comboBoxTickerSelect.FormattingEnabled = true;
            this.comboBoxTickerSelect.Location = new System.Drawing.Point(66, 87);
            this.comboBoxTickerSelect.Name = "comboBoxTickerSelect";
            this.comboBoxTickerSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTickerSelect.TabIndex = 11;
            this.comboBoxTickerSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxTickerSelect_SelectedIndexChanged);
            // 
            // groupBoxPatterns
            // 
            this.groupBoxPatterns.Controls.Add(this.radioButtonMarubozuBearish);
            this.groupBoxPatterns.Controls.Add(this.radioButtonMarubozuBullish);
            this.groupBoxPatterns.Controls.Add(this.radioButtonDoji);
            this.groupBoxPatterns.Location = new System.Drawing.Point(346, 43);
            this.groupBoxPatterns.Name = "groupBoxPatterns";
            this.groupBoxPatterns.Size = new System.Drawing.Size(167, 202);
            this.groupBoxPatterns.TabIndex = 12;
            this.groupBoxPatterns.TabStop = false;
            this.groupBoxPatterns.Text = "Patterns";
            // 
            // radioButtonMarubozuBullish
            // 
            this.radioButtonMarubozuBullish.AutoSize = true;
            this.radioButtonMarubozuBullish.Location = new System.Drawing.Point(6, 48);
            this.radioButtonMarubozuBullish.Name = "radioButtonMarubozuBullish";
            this.radioButtonMarubozuBullish.Size = new System.Drawing.Size(129, 20);
            this.radioButtonMarubozuBullish.TabIndex = 1;
            this.radioButtonMarubozuBullish.Text = "Bullish Marubozu";
            this.radioButtonMarubozuBullish.UseVisualStyleBackColor = true;
            this.radioButtonMarubozuBullish.CheckedChanged += new System.EventHandler(this.radioButtonMarubozuBullish_CheckedChanged);
            // 
            // radioButtonDoji
            // 
            this.radioButtonDoji.AutoSize = true;
            this.radioButtonDoji.Checked = true;
            this.radioButtonDoji.Location = new System.Drawing.Point(6, 21);
            this.radioButtonDoji.Name = "radioButtonDoji";
            this.radioButtonDoji.Size = new System.Drawing.Size(52, 20);
            this.radioButtonDoji.TabIndex = 0;
            this.radioButtonDoji.TabStop = true;
            this.radioButtonDoji.Text = "Doji";
            this.radioButtonDoji.UseVisualStyleBackColor = true;
            this.radioButtonDoji.CheckedChanged += new System.EventHandler(this.radioButtonDoji_CheckedChanged);
            // 
            // radioButtonMarubozuBearish
            // 
            this.radioButtonMarubozuBearish.AutoSize = true;
            this.radioButtonMarubozuBearish.Location = new System.Drawing.Point(6, 74);
            this.radioButtonMarubozuBearish.Name = "radioButtonMarubozuBearish";
            this.radioButtonMarubozuBearish.Size = new System.Drawing.Size(170, 25);
            this.radioButtonMarubozuBearish.TabIndex = 2;
            this.radioButtonMarubozuBearish.TabStop = true;
            this.radioButtonMarubozuBearish.Text = "Bearish Marubozu";
            this.radioButtonMarubozuBearish.UseVisualStyleBackColor = true;
            this.radioButtonMarubozuBearish.CheckedChanged += new System.EventHandler(this.radioButtonMarubozuBearish_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.groupBoxPatterns);
            this.Controls.Add(this.comboBoxTickerSelect);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelTickerSelect);
            this.Controls.Add(this.groupBoxPeriod);
            this.Name = "Form1";
            this.Text = "Stock Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxPatterns.ResumeLayout(false);
            this.groupBoxPatterns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.Label labelTickerSelect;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ComboBox comboBoxTickerSelect;
        private System.Windows.Forms.GroupBox groupBoxPatterns;
        private System.Windows.Forms.RadioButton radioButtonMarubozuBullish;
        private System.Windows.Forms.RadioButton radioButtonDoji;
        private System.Windows.Forms.RadioButton radioButtonMarubozuBearish;
    }
}

