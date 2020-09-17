using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Quadrate : Figure
    {
        string _name;
        double _a;
        double _sq;
        double _per;

        public Quadrate(string name, double a) : base(name)
        {
            _name = name;
            _a = a;
        }
        public override void Perimeter()
        {
            _per = 4 * _a;
            Console.WriteLine($"Perimeter of quadrate {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = _a * _a;
            Console.WriteLine($"Sqquare of quadrate {_name} = {_sq}");
        }

    }

}
