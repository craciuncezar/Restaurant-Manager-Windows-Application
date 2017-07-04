using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Restaurant_Manager_Windows_Application.Custom_User_Control
{
    public partial class BarChartUserControl : UserControl
    {
        private Restaurant restaurant = MainForm.Restaurant;
        private BarChartCategory[] _data;
        private BarChartCategory[] Data
        {
            get { return _data; }
            set
            {
                if (_data == value)
                    return;

                _data = value;

                //trigger the Paint event
                Invalidate();
            }
        }
        public BarChartUserControl()
        {
            InitializeComponent();

            ResizeRedraw = true;

            Data = new[]
            {
                new BarChartCategory("Reservations",restaurant.Reservations.Count,Color.Red),
                new BarChartCategory("Tables",restaurant.Tables.Count,Color.Blue),
                new BarChartCategory("Employee",restaurant.Employee.Count,Color.Brown),
                new BarChartCategory("Menu items",restaurant.Menu.Count,Color.Yellow)

            };
        }


        private void BarChartUserControl_Paint(object sender, PaintEventArgs e)
        {
            int legendWidth = 150;
            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;

            float width = clipRectangle.Width - legendWidth;
            float height = clipRectangle.Height;

            var barWidth = width / Data.Length;
            var maxBarHeight = height * 0.9;
            var scalingFactor = maxBarHeight / Data.Max(x => x.Number);

            for (int i = 0; i < Data.Length; i++)
            {
                Brush b = new SolidBrush(Data[i].Color);

                var barHeight = (float)(Data[i].Number * scalingFactor);

                graphics.FillRectangle(b, i * barWidth, height - barHeight, 0.8f * barWidth, barHeight);
            }

            Pen pen = new Pen(Color.Black);

            //draw the chart legend
            float xpos = width + 20;
            float ypos = 200;
            for (int i = 0; i < Data.Length; i++)
            {
                Brush b = new SolidBrush(Data[i].Color);

                graphics.FillRectangle(b, xpos, ypos, 30, 30);
                graphics.DrawRectangle(pen, xpos, ypos, 30, 30);

                Brush b2 = new SolidBrush(Color.Black);

                graphics.DrawString(
                    Data[i].Description + ": " + Data[i].Number,
                    Font,
                    b2,
                    xpos + 35,
                    ypos + 12);

                ypos += 35;
            }
        }
    }
}
