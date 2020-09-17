using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{

    class Rhomb : Figure
    {
        string _name;       //назва (ім"я) ромба
        double _a;          //сторона ромба
        double _p;          //перша діагональ
        double _q;          //друга діагональ
        double _per;        //периметр
        double _sq;         //площа

        public Rhomb(string name, double p, double q) : base(name)
        {
            _name = name;
            _p = p;
            _q = q;
        }
        public override void Perimeter()
        {
            _a = (Math.Sqrt(_p * _p + _q * _q) / 2);    //знайдемо спочатку сторону ромба
            _per = 4 * _a;                              //шукаємо периметр
            Console.WriteLine($"Side a = {_a}");
            Console.WriteLine($"Perimeter of rhomb {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = (_p * _q) / 2;                        //шукаємо площу
            Console.WriteLine($"Square of rhomb {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            return _sq;
        }
    }
}
