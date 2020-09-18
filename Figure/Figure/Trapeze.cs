using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
   
    class Trapeze : Figure
    {
        string _name;       //назва (ім"я) трапеції
        double _a;          //сторона a (верхня основа)
        double _b;          //сторона b (нижня основа)
        double _c;          //сторона c (ліва бічна)
        double _d;          //сторона d (права бічна)
        double _h;          //висота трапеції
        double _per;        //периметр       
        double _sq;         //площа

        public Trapeze(string name, double a, double b, double c, double d) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }
        public override void Perimeter()
        {
            _per = _a + _b + _c + _d;      //шукаємо периметр
            Console.WriteLine($"Perimeter of trapeze {_name} = {_per}");
        }
        public override void Square()
        {
            _h = Math.Sqrt(Math.Pow(_c, 2) - Math.Pow((Math.Pow((_a - _b), 2) + Math.Pow(_c, 2) - Math.Pow(_d, 2)) / (2 * (_a - _b)), 2));
            _sq = Math.Round(((_a + _b) / 2) * _h, 2);      //шукаємо площу
            Console.WriteLine($"Square of trapeze {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _h = Math.Sqrt(Math.Pow(_c, 2) - Math.Pow((Math.Pow((_a - _b), 2) + Math.Pow(_c, 2) - Math.Pow(_d, 2)) / (2 * (_a - _b)), 2));
            _sq = Math.Round(((_a + _b) / 2) * _h, 2);      //шукаємо площу
            return _sq;
        }
    }
}
