namespace WindowsForms_COP4365_001
{
    partial class Form_StockViewer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_loadTicker = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_loader = new System.Windows.Forms.Button();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart_candlesticks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox_DWM = new System.Windows.Forms.GroupBox();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.radioButton_Week = new System.Windows.Forms.RadioButton();
            this.radioButton_Day = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_PatternSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_candlesticks)).BeginInit();
            this.groupBox_DWM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_loadTicker
            // 
            this.openFileDialog_loadTicker.Filter = "csv files (*.csv)|*.csv|Monthly|*-Month.csv|Weekly|*-Week.csv|Daily|*-Day.csv";
            this.openFileDialog_loadTicker.InitialDirectory = "Stock Data";
            this.openFileDialog_loadTicker.Multiselect = true;
            this.openFileDialog_loadTicker.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_loadTicker_FileOk);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(3, 55);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker_endDate.TabIndex = 1;
            // 
            // button_loader
            // 
            this.button_loader.Location = new System.Drawing.Point(3, 92);
            this.button_loader.Name = "button_loader";
            this.button_loader.Size = new System.Drawing.Size(75, 23);
            this.button_loader.TabIndex = 4;
            this.button_loader.Text = "Load Ticker";
            this.button_loader.UseVisualStyleBackColor = true;
            this.button_loader.Click += new System.EventHandler(this.button_loader_Click);
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(WindowsForms_COP4365_001.Candlestick);
            // 
            // chart_candlesticks
            // 
            chartArea1.Name = "ChartArea_OHLC";
            chartArea2.AlignWithChartArea = "ChartArea_OHLC";
            chartArea2.Name = "ChartArea_Volume";
            this.chart_candlesticks.ChartAreas.Add(chartArea1);
            this.chart_candlesticks.ChartAreas.Add(chartArea2);
            this.chart_candlesticks.DataSource = this.candlestickBindingSource;
            this.chart_candlesticks.Location = new System.Drawing.Point(0, 239);
            this.chart_candlesticks.Name = "chart_candlesticks";
            series1.ChartArea = "ChartArea_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Crimson, PriceUpColor=ForestGreen";
            series1.IsVisibleInLegend = false;
            series1.Name = "Series_OHLC";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea_Volume";
            series2.IsVisibleInLegend = false;
            series2.Name = "Series_Volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "volume";
            this.chart_candlesticks.Series.Add(series1);
            this.chart_candlesticks.Series.Add(series2);
            this.chart_candlesticks.Size = new System.Drawing.Size(928, 311);
            this.chart_candlesticks.TabIndex = 5;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker_startDate.TabIndex = 7;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(3, 0);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(58, 13);
            this.label_start.TabIndex = 8;
            this.label_start.Text = "Start Date:";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(3, 39);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(55, 13);
            this.label_end.TabIndex = 9;
            this.label_end.Text = "End Date:";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(112, 92);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 10;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // groupBox_DWM
            // 
            this.groupBox_DWM.Controls.Add(this.radioButton_Month);
            this.groupBox_DWM.Controls.Add(this.radioButton_Week);
            this.groupBox_DWM.Controls.Add(this.radioButton_Day);
            this.groupBox_DWM.Location = new System.Drawing.Point(212, 16);
            this.groupBox_DWM.Name = "groupBox_DWM";
            this.groupBox_DWM.Size = new System.Drawing.Size(121, 99);
            this.groupBox_DWM.TabIndex = 11;
            this.groupBox_DWM.TabStop = false;
            this.groupBox_DWM.Text = "Select Candle Width:";
            // 
            // radioButton_Month
            // 
            this.radioButton_Month.AutoSize = true;
            this.radioButton_Month.Location = new System.Drawing.Point(6, 69);
            this.radioButton_Month.Name = "radioButton_Month";
            this.radioButton_Month.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Month.TabIndex = 2;
            this.radioButton_Month.TabStop = true;
            this.radioButton_Month.Text = "Month";
            this.radioButton_Month.UseVisualStyleBackColor = true;
            this.radioButton_Month.Click += new System.EventHandler(this.radioButton_Month_Click);
            // 
            // radioButton_Week
            // 
            this.radioButton_Week.AutoSize = true;
            this.radioButton_Week.Location = new System.Drawing.Point(6, 46);
            this.radioButton_Week.Name = "radioButton_Week";
            this.radioButton_Week.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Week.TabIndex = 1;
            this.radioButton_Week.TabStop = true;
            this.radioButton_Week.Text = "Week";
            this.radioButton_Week.UseVisualStyleBackColor = true;
            this.radioButton_Week.Click += new System.EventHandler(this.radioButton_Week_Click);
            // 
            // radioButton_Day
            // 
            this.radioButton_Day.AutoSize = true;
            this.radioButton_Day.Location = new System.Drawing.Point(6, 23);
            this.radioButton_Day.Name = "radioButton_Day";
            this.radioButton_Day.Size = new System.Drawing.Size(44, 17);
            this.radioButton_Day.TabIndex = 0;
            this.radioButton_Day.TabStop = true;
            this.radioButton_Day.Text = "Day";
            this.radioButton_Day.UseVisualStyleBackColor = true;
            this.radioButton_Day.Click += new System.EventHandler(this.radioButton_Day_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_start);
            this.panel1.Controls.Add(this.groupBox_DWM);
            this.panel1.Controls.Add(this.dateTimePicker_endDate);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_loader);
            this.panel1.Controls.Add(this.label_end);
            this.panel1.Controls.Add(this.dateTimePicker_startDate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 132);
            this.panel1.TabIndex = 12;
            // 
            // comboBox_PatternSelect
            // 
            this.comboBox_PatternSelect.FormattingEnabled = true;
            this.comboBox_PatternSelect.Location = new System.Drawing.Point(371, 27);
            this.comboBox_PatternSelect.Name = "comboBox_PatternSelect";
            this.comboBox_PatternSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PatternSelect.TabIndex = 14;
            // 
            // Form_StockViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1588, 603);
            this.Controls.Add(this.comboBox_PatternSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_candlesticks);
            this.Name = "Form_StockViewer";
            this.Text = "Stock Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_candlesticks)).EndInit();
            this.groupBox_DWM.ResumeLayout(false);
            this.groupBox_DWM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_loadTicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_loader;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_candlesticks;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.GroupBox groupBox_DWM;
        private System.Windows.Forms.RadioButton radioButton_Month;
        private System.Windows.Forms.RadioButton radioButton_Week;
        private System.Windows.Forms.RadioButton radioButton_Day;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_PatternSelect;
    }
}

