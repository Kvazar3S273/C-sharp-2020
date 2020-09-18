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
        public double Square(Figure [] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                _sq += arr[i].GetSquare();
            }
            return _sq;
        }
    }
}
