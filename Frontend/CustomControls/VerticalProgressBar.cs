using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoMonitor.Frontend.CustomControls
{
    public class VerticalProgressBar : Panel
    {
        private int _percent;
        public int Percentage
        {
            get { return _percent; }
            set { UpdatePercentage(value); }
        }




        public Color BackgroundBarColor { get; set; } = Color.Gray;
        public Color ProgressBarColor { get; set; } = Color.Red;


        public VerticalProgressBar()
            : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void UpdatePercentage(int value)
        {
            if (value > 100) value = 100;
            if (value < 0) value = 0;
            this._percent = value;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the background bar
            g.FillRectangle(new SolidBrush(BackgroundBarColor), new Rectangle(0, 0, this.Width, this.Height));
            int treshold = (int)(((decimal)this.Height / 100) * _percent);
            // Draw the progress bar
            g.FillRectangle(new SolidBrush(ProgressBarColor),
                            0,
                            treshold,
                            this.Width,
                            this.Height - treshold);

            // Draw the border
            g.DrawRectangle(new Pen(Color.FromArgb(255, 140, 140, 140)),
                            0,
                            0,
                            this.Width - 1,
                            this.Height -1 );

            base.OnPaint(e);

        }
    }
}
