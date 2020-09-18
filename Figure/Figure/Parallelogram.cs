using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Parallelogram : Figure
    {
        string _name;       //назва (ім"я) паралелограма
        double _a;          //сторона a
        double _b;          //сторона b
        double _alpha;      //кут між сторонами
        double _per;        //периметр       
        double _sq;         //площа

        public Parallelogram(string name, double a, double b, double alpha) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
            _alpha = alpha;
        }
        public override void Perimeter()
        {
            _per = 2 * (_a + _b);      //шукаємо периметр
            Console.WriteLine($"Perimeter of parallelogram {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = Math.Round(_a * _b * Math.Sin(_alpha), 2);      //шукаємо площу
            Console.WriteLine($"Square of parallelogram {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _sq = Math.Round(_a * _b * Math.Sin(_alpha), 2);      //шукаємо площу
            return _sq;
        }
    }
}
