using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    
    class Ellipse : Figure
    {
        string _name;   //назва (ім"я) круга
        double _a;      //велика піввісь
        double _b;      //мала піввісь
        double _per;    //периметр       
        double _sq;     //площа

        public Ellipse(string name, double a, double b) : base(name)
        {
            _name = name;
            _a = a;
            _b = b;
        }
        public override void Perimeter()
        {
            _per = Math.Round(Math.Sqrt((Math.Pow(_a, 2) + Math.Pow(_b, 2)) / 2) * 2 * Math.PI); //шукаємо довжину еліпса
            Console.WriteLine($"Perimeter of ellipse {_name} = {_per}");
        }
        public override void Square()
        {
            _sq = Math.Round(_a * _b * Math.PI, 2);      //шукаємо площу
            Console.WriteLine($"Square of ellipse {_name} = {_sq}");
        }
        public override double GetSquare()
        {
            return _sq;
        }
    }
}
