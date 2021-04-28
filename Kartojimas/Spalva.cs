using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class Spalva
    {
        private double maxValue = 255;
        private double minValue = 0;
        public List<double> Red { get; } = new List<double>{ 255, 0, 0 };

        public List<double> Green { get; } = new List<double> { 0, 128, 0 };
        public double Blue { get;}
        public double Color { get;}
        public Spalva(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Spalva()
        {

        }

    }
}
