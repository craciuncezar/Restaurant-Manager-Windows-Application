using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager_Windows_Application.Custom_User_Control
{
    class BarChartCategory
    {
        public string Description { get; set; }

        public float Number { get; set; }

        public Color Color { get; set; }

        public BarChartCategory(string description, float number, Color color)
        {
            Description = description;
            Number = number;
            Color = color;
        }
    }
}
