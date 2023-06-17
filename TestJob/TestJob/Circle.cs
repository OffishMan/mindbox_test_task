using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJob
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Радиус не может быть отрицательным или нулевым");
            }
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
