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

        private int CurrentHumidity { get; set; }
        private int CurrentTemperature { get; set; }

        private int _maxHistoryCount = 40;
        private int _maxTemperature = 70;
        private int _minTemperature = -20;


        public MainPage()
        {
            InitializeComponent();
            InitializeGUI();
            AssignDataToCharts();
        }

        private void InitializeGUI()
        {

            DataProcessor.ArduinoUpdateEvent += ProcessArduinoUpdate;

            chart_Humidity.ChartAreas[0].AxisY.Maximum = 100;
            chart_Humidity.ChartAreas[0].AxisY.Minimum = 0;
            chart_Humidity.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

            chart_Temperature.ChartAreas[0].AxisY.Maximum = 70;
            chart_Temperature.ChartAreas[0].AxisY.Minimum = -20;
            chart_Temperature.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;

            _tempProgressBar = new VerticalProgressBar()
            {
                Size = new Size(30, 130),
                Location = new Point(40, 50),
            };

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

            Label label_TemperatureMeasurement = new Label();

            label_TemperatureMeasurement.Location = new Point(_tempProgressBar.Location.X + _tempProgressBar.Width + 40,
                                                              -_tempProgressBar.Location.Y + (_tempProgressBar.Size.Height / 2));

            label_MinTemp.Text = "32 °C";
            label_MinTemp.Font = new Font("Arial", 16, FontStyle.Bold);
            //label_MaxTemp. = true;
            label_MinTemp.ForeColor = GUIConstants.COLOR_TemperatureBarFill;

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
            //int percent = (int)((temperature / ))
            return 30;
        }

        private void UpdateForm(ArduinoUpdateEventModel e)
        {
            if (e.Temperature > _maxTemperature) e.Temperature = _maxTemperature;
            if (e.Temperature < _minTemperature) e.Temperature = _minTemperature;

            progress_Humidity.Value = e.Humidity;
            _tempProgressBar.Percentage = GetTemperaturePercentage(e.Temperature);
            

            // Add to the collections for the charts, capping it at maxHistoryCount

            chart_Temperature.Series[0].Points.AddY(e.Temperature);
            //chart_Temperature.Series[0].Points.
            if (chart_Temperature.Series[0].Points.Count > _maxHistoryCount)
            {
                chart_Temperature.Series[0].Points.RemoveAt(0);
            }

            chart_Humidity.Series[0].Points.AddY(e.Humidity);
            if (chart_Humidity.Series[0].Points.Count > _maxHistoryCount)
            {
                chart_Humidity.Series[0].Points.RemoveAt(0);
            }
        }

        private void AssignDataToCharts()
        {
            //chart_Temperature.seri
        }
    }
}
