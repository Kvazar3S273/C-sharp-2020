using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
   
    class Rectangle : Figure
    {
        string _name;   //назва (ім"я) прямокутника
        double _a;      //сторона a
        double _b;      //сторона b
        double _per;    //периметр       
        double _sq;     //площа

        public Rectangle(string name, double a, double b) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
        }
        public override void Perimeter()
        {
            _per = 2 * (_a + _b);      //шукаємо периметр
            Console.WriteLine($"Perimeter of rectangle {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = _a * _b;      //шукаємо площу
            Console.WriteLine($"Square of rectangle {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _sq = _a * _b;      //шукаємо площу
            return _sq;
        }
    }
}
