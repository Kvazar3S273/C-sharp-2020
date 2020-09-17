using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Polygon 
    {
        string _name;
        double _sq=0;
        public Polygon(string name) 
        {
            _name = name;
        }
        public void Square(Figure [] arr)
        {
            //foreach (var item in arr)
            //{
            //    _sq += item.GetSquare();
            //}

            for (int i = 0; i < 3; i++)
            {
                _sq += arr[i].GetSquare();

            }
            Console.WriteLine($"Square of polygon {_name} = {_sq}");
        }
    }
}
