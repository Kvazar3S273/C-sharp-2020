using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    public abstract class Figure
    {
        string _name;
        public Figure(string name)
        {
            _name = name;
        }
        public abstract void Square();
        public abstract void Perimeter();
    }
}
