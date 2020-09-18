using System;

namespace Figure
{
    class Triangle : Figure
    {
        string _name;   //назва (ім"я) трикутника
        double _a;      //сторона а
        double _b;      //сторона b
        double _c;      //сторона с
        double _per;    //периметр
        double _sq;     //площа
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
            _c = c;
        }
        public override void Perimeter()
        {
            _per = _a + _b + _c;    //шукаємо периметр
            Console.WriteLine($"Perimeter of triangle {_name} = {_per}");
        }

        public override void Square()   //шукаємо площу, округлюємо до 2х знаків після коми
        {
            _sq = Math.Round(Math.Sqrt(_per / 2 * (_per / 2 - _a) * (_per / 2 - _b) * (_per / 2 - _c)), 2); //формула Герона
            Console.WriteLine($"Square of triangle {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _per = _a + _b + _c;    //шукаємо периметр
            _sq = Math.Round(Math.Sqrt(_per / 2 * (_per / 2 - _a) * (_per / 2 - _b) * (_per / 2 - _c)), 2); //формула Герона
            return _sq;
        }
    }
}
