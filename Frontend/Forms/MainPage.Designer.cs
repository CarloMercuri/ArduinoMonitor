namespace ArduinoMonitor.Frontend.Forms
{
    partial class MainPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.progress_Humidity = new CircularProgressBar.CircularProgressBar();
            this.panel_Humidity_Parent = new System.Windows.Forms.Panel();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.panel_Temperature_Parent = new System.Windows.Forms.Panel();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.chart_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_Test = new System.Windows.Forms.Label();
            this.btn_ScoutNetwork = new System.Windows.Forms.Button();
            this.panel_Humidity_Parent.SuspendLayout();
            this.panel_Temperature_Parent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Humidity)).BeginInit();
            this.SuspendLayout();
            // 
            // progress_Humidity
            // 
            this.progress_Humidity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_Humidity.AnimationSpeed = 500;
            this.progress_Humidity.BackColor = System.Drawing.Color.Transparent;
            this.progress_Humidity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progress_Humidity.ForeColor = System.Drawing.Color.Cyan;
            this.progress_Humidity.InnerColor = System.Drawing.Color.White;
            this.progress_Humidity.InnerMargin = 2;
            this.progress_Humidity.InnerWidth = -1;
            this.progress_Humidity.Location = new System.Drawing.Point(38, 45);
            this.progress_Humidity.MarqueeAnimationSpeed = 2000;
            this.progress_Humidity.Name = "progress_Humidity";
            this.progress_Humidity.OuterColor = System.Drawing.Color.Silver;
            this.progress_Humidity.OuterMargin = -25;
            this.progress_Humidity.OuterWidth = 26;
            this.progress_Humidity.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progress_Humidity.ProgressWidth = 25;
            this.progress_Humidity.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progress_Humidity.Size = new System.Drawing.Size(120, 120);
            this.progress_Humidity.StartAngle = 90;
            this.progress_Humidity.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_Humidity.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_Humidity.SubscriptText = "";
            this.progress_Humidity.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progress_Humidity.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_Humidity.SuperscriptText = "";
            this.progress_Humidity.TabIndex = 0;
            this.progress_Humidity.Text = "0%";
            this.progress_Humidity.TextMargin = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.progress_Humidity.Value = 10;
            // 
            // panel_Humidity_Parent
            // 
            this.panel_Humidity_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Humidity_Parent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Humidity_Parent.Controls.Add(this.label_Humidity);
            this.panel_Humidity_Parent.Controls.Add(this.progress_Humidity);
            this.panel_Humidity_Parent.Location = new System.Drawing.Point(282, 244);
            this.panel_Humidity_Parent.Name = "panel_Humidity_Parent";
            this.panel_Humidity_Parent.Size = new System.Drawing.Size(212, 197);
            this.panel_Humidity_Parent.TabIndex = 1;
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Humidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Humidity.Location = new System.Drawing.Point(53, 17);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(95, 25);
            this.label_Humidity.TabIndex = 1;
            this.label_Humidity.Text = "Humidity";
            // 
            // panel_Temperature_Parent
            // 
            this.panel_Temperature_Parent.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Temperature_Parent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Temperature_Parent.Controls.Add(this.label_Temperature);
            this.panel_Temperature_Parent.Location = new System.Drawing.Point(282, 27);
            this.panel_Temperature_Parent.Name = "panel_Temperature_Parent";
            this.panel_Temperature_Parent.Size = new System.Drawing.Size(212, 197);
            this.panel_Temperature_Parent.TabIndex = 2;
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Temperature.Location = new System.Drawing.Point(38, 11);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(125, 25);
            this.label_Temperature.TabIndex = 1;
            this.label_Temperature.Text = "Temperature";
            // 
            // chart_Temperature
            // 
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea1.Name = "ChartArea1";
            this.chart_Temperature.ChartAreas.Add(chartArea1);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_Temperature.Legends.Add(legend1);
            this.chart_Temperature.Location = new System.Drawing.Point(521, 27);
            this.chart_Temperature.Name = "chart_Temperature";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chart_Temperature.Series.Add(series1);
            this.chart_Temperature.Size = new System.Drawing.Size(492, 197);
            this.chart_Temperature.TabIndex = 3;
            this.chart_Temperature.Text = "chart1";
            // 
            // chart_Humidity
            // 
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            chartArea2.Name = "ChartArea1";
            this.chart_Humidity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Humidity.Legends.Add(legend2);
            this.chart_Humidity.Location = new System.Drawing.Point(521, 244);
            this.chart_Humidity.Name = "chart_Humidity";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.chart_Humidity.Series.Add(series2);
            this.chart_Humidity.Size = new System.Drawing.Size(492, 197);
            this.chart_Humidity.TabIndex = 4;
            this.chart_Humidity.Text = "chart2";
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Location = new System.Drawing.Point(238, 9);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(38, 15);
            this.label_Test.TabIndex = 5;
            this.label_Test.Text = "label1";
            this.label_Test.Click += new System.EventHandler(this.label_Test_Click);
            // 
            // btn_ScoutNetwork
            // 
            this.btn_ScoutNetwork.Location = new System.Drawing.Point(50, 27);
            this.btn_ScoutNetwork.Name = "btn_ScoutNetwork";
            this.btn_ScoutNetwork.Size = new System.Drawing.Size(118, 40);
            this.btn_ScoutNetwork.TabIndex = 6;
            this.btn_ScoutNetwork.Text = "Scout Network";
            this.btn_ScoutNetwork.UseVisualStyleBackColor = true;
            this.btn_ScoutNetwork.Click += new System.EventHandler(this.btn_ScoutNetwork_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1041, 466);
            this.Controls.Add(this.btn_ScoutNetwork);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.chart_Humidity);
            this.Controls.Add(this.chart_Temperature);
            this.Controls.Add(this.panel_Temperature_Parent);
            this.Controls.Add(this.panel_Humidity_Parent);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.panel_Humidity_Parent.ResumeLayout(false);
            this.panel_Humidity_Parent.PerformLayout();
            this.panel_Temperature_Parent.ResumeLayout(false);
            this.panel_Temperature_Parent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Humidity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progress_Humidity;
        private Panel panel_Humidity_Parent;
        private Label label_Humidity;
        private Panel panel_Temperature_Parent;
        private Label label_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Humidity;
        private Label label_Test;
        private Button btn_ScoutNetwork;
    }
}