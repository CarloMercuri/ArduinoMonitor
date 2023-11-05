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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            progress_Humidity = new CircularProgressBar.CircularProgressBar();
            panel_Humidity_Parent = new Panel();
            label_Humidity = new Label();
            panel_Temperature_Parent = new Panel();
            label_Temperature = new Label();
            chart_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart_Humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label_Test = new Label();
            btn_ScoutNetwork = new Button();
            pBox_Joystick = new PictureBox();
            panel1 = new Panel();
            btn_Calibrate = new Button();
            panel_Humidity_Parent.SuspendLayout();
            panel_Temperature_Parent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Temperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_Humidity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBox_Joystick).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // progress_Humidity
            // 
            progress_Humidity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progress_Humidity.AnimationSpeed = 500;
            progress_Humidity.BackColor = Color.Transparent;
            progress_Humidity.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            progress_Humidity.ForeColor = Color.Cyan;
            progress_Humidity.InnerColor = Color.White;
            progress_Humidity.InnerMargin = 2;
            progress_Humidity.InnerWidth = -1;
            progress_Humidity.Location = new Point(38, 45);
            progress_Humidity.MarqueeAnimationSpeed = 2000;
            progress_Humidity.Name = "progress_Humidity";
            progress_Humidity.OuterColor = Color.Silver;
            progress_Humidity.OuterMargin = -25;
            progress_Humidity.OuterWidth = 26;
            progress_Humidity.ProgressColor = Color.FromArgb(0, 192, 192);
            progress_Humidity.ProgressWidth = 25;
            progress_Humidity.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            progress_Humidity.Size = new Size(120, 120);
            progress_Humidity.StartAngle = 90;
            progress_Humidity.SubscriptColor = Color.FromArgb(166, 166, 166);
            progress_Humidity.SubscriptMargin = new Padding(10, -35, 0, 0);
            progress_Humidity.SubscriptText = "";
            progress_Humidity.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progress_Humidity.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progress_Humidity.SuperscriptText = "";
            progress_Humidity.TabIndex = 0;
            progress_Humidity.Text = "0%";
            progress_Humidity.TextMargin = new Padding(4, 1, 0, 0);
            progress_Humidity.Value = 10;
            // 
            // panel_Humidity_Parent
            // 
            panel_Humidity_Parent.BackColor = SystemColors.Control;
            panel_Humidity_Parent.BorderStyle = BorderStyle.Fixed3D;
            panel_Humidity_Parent.Controls.Add(label_Humidity);
            panel_Humidity_Parent.Controls.Add(progress_Humidity);
            panel_Humidity_Parent.Location = new Point(282, 244);
            panel_Humidity_Parent.Name = "panel_Humidity_Parent";
            panel_Humidity_Parent.Size = new Size(212, 197);
            panel_Humidity_Parent.TabIndex = 1;
            // 
            // label_Humidity
            // 
            label_Humidity.AutoSize = true;
            label_Humidity.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_Humidity.ForeColor = Color.FromArgb(0, 192, 192);
            label_Humidity.Location = new Point(53, 17);
            label_Humidity.Name = "label_Humidity";
            label_Humidity.Size = new Size(95, 25);
            label_Humidity.TabIndex = 1;
            label_Humidity.Text = "Humidity";
            // 
            // panel_Temperature_Parent
            // 
            panel_Temperature_Parent.BackColor = SystemColors.Control;
            panel_Temperature_Parent.BorderStyle = BorderStyle.Fixed3D;
            panel_Temperature_Parent.Controls.Add(label_Temperature);
            panel_Temperature_Parent.Location = new Point(282, 27);
            panel_Temperature_Parent.Name = "panel_Temperature_Parent";
            panel_Temperature_Parent.Size = new Size(212, 197);
            panel_Temperature_Parent.TabIndex = 2;
            // 
            // label_Temperature
            // 
            label_Temperature.AutoSize = true;
            label_Temperature.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_Temperature.ForeColor = Color.FromArgb(255, 128, 0);
            label_Temperature.Location = new Point(38, 11);
            label_Temperature.Name = "label_Temperature";
            label_Temperature.Size = new Size(125, 25);
            label_Temperature.TabIndex = 1;
            label_Temperature.Text = "Temperature";
            // 
            // chart_Temperature
            // 
            chartArea3.AxisX.LabelStyle.ForeColor = Color.FromArgb(255, 128, 0);
            chartArea3.AxisX.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.AxisX.MajorTickMark.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.AxisY.LabelStyle.ForeColor = Color.FromArgb(255, 128, 0);
            chartArea3.AxisY.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.AxisY.MajorTickMark.LineColor = Color.FromArgb(235, 235, 235);
            chartArea3.Name = "ChartArea1";
            chart_Temperature.ChartAreas.Add(chartArea3);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            chart_Temperature.Legends.Add(legend3);
            chart_Temperature.Location = new Point(521, 27);
            chart_Temperature.Name = "chart_Temperature";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.FromArgb(255, 128, 0);
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            chart_Temperature.Series.Add(series3);
            chart_Temperature.Size = new Size(492, 197);
            chart_Temperature.TabIndex = 3;
            chart_Temperature.Text = "chart1";
            // 
            // chart_Humidity
            // 
            chartArea4.AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 192, 192);
            chartArea4.AxisX.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.AxisX.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.AxisX.MajorTickMark.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 192, 192);
            chartArea4.AxisY.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.AxisY.MajorGrid.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.AxisY.MajorTickMark.LineColor = Color.FromArgb(235, 235, 235);
            chartArea4.Name = "ChartArea1";
            chart_Humidity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart_Humidity.Legends.Add(legend4);
            chart_Humidity.Location = new Point(521, 244);
            chart_Humidity.Name = "chart_Humidity";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.FromArgb(0, 192, 192);
            series4.Legend = "Legend1";
            series4.Name = "Humidity";
            chart_Humidity.Series.Add(series4);
            chart_Humidity.Size = new Size(492, 197);
            chart_Humidity.TabIndex = 4;
            chart_Humidity.Text = "chart2";
            // 
            // label_Test
            // 
            label_Test.AutoSize = true;
            label_Test.Location = new Point(238, 9);
            label_Test.Name = "label_Test";
            label_Test.Size = new Size(38, 15);
            label_Test.TabIndex = 5;
            label_Test.Text = "label1";
            label_Test.Click += label_Test_Click;
            // 
            // btn_ScoutNetwork
            // 
            btn_ScoutNetwork.Location = new Point(50, 27);
            btn_ScoutNetwork.Name = "btn_ScoutNetwork";
            btn_ScoutNetwork.Size = new Size(118, 40);
            btn_ScoutNetwork.TabIndex = 6;
            btn_ScoutNetwork.Text = "Scout Network";
            btn_ScoutNetwork.UseVisualStyleBackColor = true;
            btn_ScoutNetwork.Click += btn_ScoutNetwork_Click;
            // 
            // pBox_Joystick
            // 
            pBox_Joystick.Location = new Point(23, 14);
            pBox_Joystick.Name = "pBox_Joystick";
            pBox_Joystick.Size = new Size(125, 129);
            pBox_Joystick.TabIndex = 7;
            pBox_Joystick.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pBox_Joystick);
            panel1.Location = new Point(20, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 230);
            panel1.TabIndex = 8;
            // 
            // btn_Calibrate
            // 
            btn_Calibrate.Location = new Point(70, 194);
            btn_Calibrate.Name = "btn_Calibrate";
            btn_Calibrate.Size = new Size(120, 30);
            btn_Calibrate.TabIndex = 6;
            btn_Calibrate.Text = "Calibrate Joystick";
            btn_Calibrate.UseVisualStyleBackColor = true;
            btn_Calibrate.Click += btn_Calibrate_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1041, 466);
            Controls.Add(panel1);
            Controls.Add(btn_Calibrate);
            Controls.Add(btn_ScoutNetwork);
            Controls.Add(label_Test);
            Controls.Add(chart_Humidity);
            Controls.Add(chart_Temperature);
            Controls.Add(panel_Temperature_Parent);
            Controls.Add(panel_Humidity_Parent);
            Name = "MainPage";
            Text = "MainPage";
            panel_Humidity_Parent.ResumeLayout(false);
            panel_Humidity_Parent.PerformLayout();
            panel_Temperature_Parent.ResumeLayout(false);
            panel_Temperature_Parent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Temperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_Humidity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBox_Joystick).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pBox_Joystick;
        private Panel panel1;
        private Button btn_Calibrate;
    }
}