using ArduinoMonitor.Frontend.CustomControls;
using ArduinoMonitor.Frontend.Styling;
using ArduinoMonitor.Network.DataHandler;
using ArduinoMonitor.Network.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArduinoMonitor.Frontend.Forms
{
    public partial class MainPage : Form
    {
        private VerticalProgressBar _tempProgressBar;
        private Label label_TemperatureMeasurement;

        private int CurrentHumidity { get; set; }
        private int CurrentTemperature { get; set; }


        private int _maxHistoryCount = 40;
        private int _maxTemperature = 70;
        private int _minTemperature = -20;
        private int chart_Temp_x = 1;
        private int chart_Humidity_x = 1;
        private int chart_x_Max = 20;


        // Picturebox
        private int pBox_Size = 220;

        // Premade this calculation, to save it on the drawing 
        private float pBox_perCent_Unit = 2.2f;

        private Point joystick_ball_location;
        private Point joystick_calibration_adjustment = new Point(0, 0);
        private int joystick_ball_size = 20;
        private int joystick_ball_half_size = 10;
        private Point joystick_raw_axis = new Point(0, 0);
        private Pen pBox_OuterCirclePen = new Pen(Color.FromArgb(255, 0, 255, 0), 4);
        private Brush pBox_JoystickCircleBrush = new SolidBrush(Color.White);

        private NetworkDataProcessor _netProcessor;

        public MainPage(NetworkDataProcessor networkProcessor)
        {
            InitializeComponent();
            _netProcessor = networkProcessor;
            InitializeGUI();
            AssignDataToCharts();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Code
            NetworkDataProcessor.ArduinoUpdateEvent -= ProcessArduinoUpdate;
        }

        private void InitializeGUI()
        {

            NetworkDataProcessor.ArduinoUpdateEvent += ProcessArduinoUpdate;

            chart_Humidity.ChartAreas[0].AxisY.Maximum = 100;
            chart_Humidity.ChartAreas[0].AxisY.Minimum = 0;
            chart_Humidity.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

            chart_Temperature.ChartAreas[0].AxisY.Maximum = 70;
            chart_Temperature.ChartAreas[0].AxisY.Minimum = -20;
            chart_Temperature.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

            _tempProgressBar = new VerticalProgressBar();

            _tempProgressBar.Size = new Size(30, 130);
            _tempProgressBar.Location = new Point(40, 50);

            _tempProgressBar.BackgroundBarColor = GUIConstants.COLOR_LightGray;
            _tempProgressBar.ProgressBarColor = GUIConstants.COLOR_TemperatureBarFill;
            _tempProgressBar.Percentage = 40;


            _tempProgressBar.Visible = true;

            panel_Temperature_Parent.Controls.Add(_tempProgressBar);

            //
            // LABEL Max Temperature
            //

            Label label_MaxTemp = new Label();
            label_MaxTemp.Location = new Point(_tempProgressBar.Location.X + _tempProgressBar.Width + 5,
                                               _tempProgressBar.Location.Y - 3);
            label_MaxTemp.Text = "70";
            label_MaxTemp.Font = new Font("Arial", 12, FontStyle.Bold);
            //label_MaxTemp. = true;
            label_MaxTemp.ForeColor = GUIConstants.COLOR_TemperatureLabels;

            panel_Temperature_Parent.Controls.Add(label_MaxTemp);

            //
            // LABEL Min Temperature
            //

            Label label_MinTemp = new Label();
            label_MinTemp.Location = new Point(_tempProgressBar.Location.X + _tempProgressBar.Width + 5,
                                               _tempProgressBar.Location.Y + _tempProgressBar.Height - 16);
            label_MinTemp.Text = "-20";
            label_MinTemp.Font = new Font("Arial", 12, FontStyle.Bold);
            //label_MaxTemp. = true;
            label_MinTemp.ForeColor = GUIConstants.COLOR_TemperatureLabels;

            panel_Temperature_Parent.Controls.Add(label_MinTemp);

            //
            // LABEL Temperature Measured
            //

            label_TemperatureMeasurement = new Label();
            label_TemperatureMeasurement.Location = new Point(_tempProgressBar.Location.X + _tempProgressBar.Width + 20,
                                                              _tempProgressBar.Location.Y + (_tempProgressBar.Height / 2) - 20);

            label_Test.Text = $"bar location Y: {_tempProgressBar.Location}, half: {_tempProgressBar.Size.Height / 2}, label loc: {label_TemperatureMeasurement.Location}";

            label_TemperatureMeasurement.Text = "32 °C";
            label_TemperatureMeasurement.Visible = true;
            label_TemperatureMeasurement.Font = new Font("Arial", 15, FontStyle.Bold);
            //label_MaxTemp. = true;
            label_TemperatureMeasurement.ForeColor = GUIConstants.COLOR_TemperatureBarFill;
            panel_Temperature_Parent.Controls.Add(label_TemperatureMeasurement);

            //
            // Joystick Picturebox
            //
            pBox_Joystick.Size = new Size(pBox_Size, pBox_Size);
            pBox_Joystick.Location = new Point(2, 2);
            pBox_Joystick.Paint += new PaintEventHandler(JoystickPBoxPaint);

            joystick_ball_location = new Point(pBox_Joystick.Size.Width / 2,
                                               pBox_Joystick.Size.Height / 2);
            pBox_Joystick.Invalidate();
        }

        private void ProcessArduinoUpdate(object? sender, ArduinoUpdateEventModel e)
        {
            this.CurrentTemperature = e.Temperature;
            this.CurrentHumidity = e.Humidity;

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { UpdateForm(e); });
            }

        }

        private int GetTemperaturePercentage(int temperature)
        {
            //currentPercent = (int)((position / size) * 100M);
            int minAbsolute = Math.Abs(_minTemperature);
            int size = Math.Abs(_maxTemperature) + minAbsolute;
            int position = minAbsolute + temperature;
            decimal t1 = (decimal)position / (decimal)size;
            int percent = (int)(t1 * 100M);

            //label_Test.Text = $"Temperature: {temperature}. Percent: {percent}. minAbsolute: {minAbsolute} - size: {size} - position: {position} - t1: {t1}";
            return percent;
        }

        private void UpdateForm(ArduinoUpdateEventModel e)
        {
            if (e.Temperature > _maxTemperature) e.Temperature = _maxTemperature;
            if (e.Temperature < _minTemperature) e.Temperature = _minTemperature;
            if (e.Temperature == 0) e.Temperature = 1;

            progress_Humidity.Value = e.Humidity;
            _tempProgressBar.Percentage = GetTemperaturePercentage(e.Temperature);
            label_TemperatureMeasurement.Text = $"{e.Temperature} °C";
            progress_Humidity.Text = $"{e.Humidity}%";

            //
            // Joystick
            //

            // The values we are getting from the Arduino go from 0 to 1024 (capping it at 1000 for simplicity)
            // First We divide it by 100 and floor it, which basically gives us a percent value from 0 to 100
            // That's what we are going to use to display the circle
            if (e.xAxis > 1000) e.xAxis = 1000;
            if (e.yAxis > 1000) e.yAxis = 1000;

            joystick_raw_axis = new Point(e.xAxis, e.yAxis);

            // Percent values
            //int xAxis_normalized = (int)Math.Floor((decimal)e.xAxis / 10M);
            //int YAxis_normalized = (int)Math.Floor((decimal)e.yAxis / 10M);
            int xPercent = 0;
            if(joystick_calibration_adjustment.X > 0)
            {
                xPercent = joystick_calibration_adjustment.X * 2;
            }

            int yPercent = 0;
            if (joystick_calibration_adjustment.Y > 0)
            {
                yPercent = joystick_calibration_adjustment.Y * 2;
            }

            int ball_x = (int)(pBox_perCent_Unit * (e.xAxis - (50 / 100 * xPercent)));
            int ball_y = (int)(pBox_perCent_Unit * (e.yAxis + joystick_calibration_adjustment.Y));

            joystick_ball_location = new Point(ball_x, ball_y);

            // Add to the collections for the charts, capping it at maxHistoryCount

            // Temperature chart
            chart_Temperature.Series[0].Points.AddXY(chart_Temp_x, e.Temperature);
            chart_Temp_x++;
            //if(chart_Temperature.Series[0].Points.Count > chart_x_Max) chart_Temperature.Series[0].Points.RemoveAt(0);
            //if (chart_Temperature.Series[0].Points.Count > _maxHistoryCount)
            //{
            //    chart_Temperature.Series[0].Points.RemoveAt(0);
            //}

            // Humidity chart
            chart_Humidity.Series[0].Points.AddXY(chart_Humidity_x, e.Humidity);
            chart_Humidity_x++;
            //if (chart_Humidity_x > chart_x_Max) chart_Humidity_x = 1;
            //if (chart_Humidity.Series[0].Points.Count > _maxHistoryCount)
            //{
            //    chart_Humidity.Series[0].Points.RemoveAt(0);
            //}

            label_Test.Text = $"Temp: {e.Humidity}. Humidity: {e.Humidity}. X-Axis: {e.xAxis}. Y-Axis: {e.yAxis}";

            pBox_Joystick.Invalidate();
        }

        private void JoystickPBoxPaint(object sender, PaintEventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            // Outer circle
            e.Graphics.DrawEllipse(pBox_OuterCirclePen, 5, 5, pBox_Size - 10, pBox_Size - 10);

            // We are setting the coordinates from the arduino input to the MIDDLE of the circle,
            // so we have to adjust for that
            e.Graphics.FillEllipse(pBox_JoystickCircleBrush,
                                   joystick_ball_location.X - joystick_ball_half_size,
                                   joystick_ball_location.Y - joystick_ball_half_size,
                                   joystick_ball_size,
                                   joystick_ball_size);
        }

        private void AssignDataToCharts()
        {
            //chart_Temperature.seri
        }

        private void label_Test_Click(object sender, EventArgs e)
        {

        }

        private void btn_ScoutNetwork_Click(object sender, EventArgs e)
        {
            _netProcessor.ScoutNetwork();
        }

        private void btn_Calibrate_Click(object sender, EventArgs e)
        {
            joystick_calibration_adjustment = new Point((50 - joystick_raw_axis.X), (50 - joystick_raw_axis.Y));
        }
    }
}
