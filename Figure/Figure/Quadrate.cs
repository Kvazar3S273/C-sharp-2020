using System;

namespace Figure
{
    class Quadrate : Figure
    {
        string _name;   //назва (ім"я) квадрата
        double _a;      //сторона квадрата
        double _per;    //периметр       
        double _sq;     //площа

        public Quadrate(string name, double a) : base(name)
        {
            _name = name;
            _a = a;
        }
        public override void Perimeter()
        {
            _per = 4 * _a;      //шукаємо периметр
            Console.WriteLine($"Perimeter of quadrate {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = _a * _a;      //шукаємо площу
            Console.WriteLine($"Square of quadrate {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _sq = _a * _a;      //шукаємо площу
            return _sq;
        }

    }

}
