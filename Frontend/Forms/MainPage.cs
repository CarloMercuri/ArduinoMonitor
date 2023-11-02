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
    }
}
