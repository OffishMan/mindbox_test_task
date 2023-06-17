using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJob
{
    public class Triangle : IFigure
    {
        private double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            if (!(a > 0 && b > 0 && c > 0))
            {
                throw new ArgumentException("Ни одна из сторон не должна быть меньше либо равна 0");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            var perimeter = (_a + _b + _c)/2; //Полупериметр
            var area = Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c)); //Формула Герона

            return area;
        }

        public bool IsRectangular()
        {
            var sides = new double[3]
            {
                _a,
                _b,
                _c
            };
            Array.Sort(sides, (x, y) => y.CompareTo(x));

            return Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2);
        }
    }
}
