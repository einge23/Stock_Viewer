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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog_loadTicker = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.button_loader = new System.Windows.Forms.Button();
            this.dataGridView_tickerGrid = new System.Windows.Forms.DataGridView();
            this.chart_candlesticks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox_DWM = new System.Windows.Forms.GroupBox();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.radioButton_Week = new System.Windows.Forms.RadioButton();
            this.radioButton_Day = new System.Windows.Forms.RadioButton();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjcloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_candlesticks)).BeginInit();
            this.groupBox_DWM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_loadTicker
            // 
            this.openFileDialog_loadTicker.Filter = "csv files (*.csv)|*.csv|Monthly|*-Month.csv|Weekly|*-Week.csv|Daily|*-Day.csv";
            this.openFileDialog_loadTicker.InitialDirectory = "Stock Data";
            this.openFileDialog_loadTicker.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_loadTicker_FileOk);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(12, 64);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker_endDate.TabIndex = 1;
            // 
            // button_loader
            // 
            this.button_loader.Location = new System.Drawing.Point(12, 101);
            this.button_loader.Name = "button_loader";
            this.button_loader.Size = new System.Drawing.Size(75, 23);
            this.button_loader.TabIndex = 4;
            this.button_loader.Text = "Load Ticker";
            this.button_loader.UseVisualStyleBackColor = true;
            this.button_loader.Click += new System.EventHandler(this.button_loader_Click);
            // 
            // dataGridView_tickerGrid
            // 
            this.dataGridView_tickerGrid.AutoGenerateColumns = false;
            this.dataGridView_tickerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.adjcloseDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_tickerGrid.DataSource = this.candlestickBindingSource;
            this.dataGridView_tickerGrid.Location = new System.Drawing.Point(361, 9);
            this.dataGridView_tickerGrid.Name = "dataGridView_tickerGrid";
            this.dataGridView_tickerGrid.Size = new System.Drawing.Size(763, 150);
            this.dataGridView_tickerGrid.TabIndex = 3;
            // 
            // chart_candlesticks
            // 
            chartArea1.Name = "ChartArea_OHLC";
            chartArea2.AlignWithChartArea = "ChartArea_OHLC";
            chartArea2.Name = "ChartArea_Volume";
            this.chart_candlesticks.ChartAreas.Add(chartArea1);
            this.chart_candlesticks.ChartAreas.Add(chartArea2);
            this.chart_candlesticks.DataSource = this.candlestickBindingSource;
            legend1.Name = "Legend1";
            this.chart_candlesticks.Legends.Add(legend1);
            this.chart_candlesticks.Location = new System.Drawing.Point(0, 165);
            this.chart_candlesticks.Name = "chart_candlesticks";
            series1.ChartArea = "ChartArea_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Crimson, PriceUpColor=ForestGreen";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series_OHLC";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea_Volume";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series_Volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "volume";
            this.chart_candlesticks.Series.Add(series1);
            this.chart_candlesticks.Series.Add(series2);
            this.chart_candlesticks.Size = new System.Drawing.Size(1392, 385);
            this.chart_candlesticks.TabIndex = 5;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker_startDate.TabIndex = 7;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(12, 9);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(58, 13);
            this.label_start.TabIndex = 8;
            this.label_start.Text = "Start Date:";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(12, 48);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(55, 13);
            this.label_end.TabIndex = 9;
            this.label_end.Text = "End Date:";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(121, 101);
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
            this.groupBox_DWM.Location = new System.Drawing.Point(221, 25);
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
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(WindowsForms_COP4365_001.Candlestick);
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            // 
            // adjcloseDataGridViewTextBoxColumn
            // 
            this.adjcloseDataGridViewTextBoxColumn.DataPropertyName = "adj_close";
            this.adjcloseDataGridViewTextBoxColumn.HeaderText = "adj_close";
            this.adjcloseDataGridViewTextBoxColumn.Name = "adjcloseDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Form_StockViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1588, 603);
            this.Controls.Add(this.groupBox_DWM);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.chart_candlesticks);
            this.Controls.Add(this.dataGridView_tickerGrid);
            this.Controls.Add(this.button_loader);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Name = "Form_StockViewer";
            this.Text = "Stock Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_candlesticks)).EndInit();
            this.groupBox_DWM.ResumeLayout(false);
            this.groupBox_DWM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_loadTicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button button_loader;
        private System.Windows.Forms.DataGridView dataGridView_tickerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjcloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
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
    }
}

