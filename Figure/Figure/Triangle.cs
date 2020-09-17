using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Triangle : Figure
    {
        string _name;
        double _a;
        double _b;
        double _c;
        double _sq;
        double _per;
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
            _c = c;
        }
        public override void Perimeter()
        {
            _per = _a + _b + _c;
            Console.WriteLine($"Perimeter of triangle {_name} = {_per}");
        }

        public override void Square()
        {
            _sq = Math.Round(Math.Sqrt(_per * (_per - _a) * (_per - _b) * (_per - _c)), 2);
            Console.WriteLine($"Sqquare of triangle {_name} = {_sq}");
        }
    }
}
