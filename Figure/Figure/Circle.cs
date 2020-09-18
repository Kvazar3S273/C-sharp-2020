using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    
    class Circle : Figure
    {
        string _name;   //назва (ім"я) круга
        double _r;      //радіус круга
        double _per;    //периметр       
        double _sq;     //площа

        public Circle(string name, double r) : base(name)
        {
            _name = name;
            _r = r;
        }
        public override void Perimeter()
        {
            _per = Math.Round(2 * _r * Math.PI, 2);      //шукаємо довжину кола
            Console.WriteLine($"Perimeter of circle {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = Math.Round(_r * _r * Math.PI, 2);      //шукаємо площу
            Console.WriteLine($"Square of circle {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            _sq = Math.Round(_r * _r * Math.PI, 2);      //шукаємо площу
            return _sq;
        }
    }
}
