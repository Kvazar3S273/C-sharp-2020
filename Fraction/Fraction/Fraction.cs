using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Fraction
    {
        public int up { set; get; }    //numerator (чисельник)
        public int down { set; get; }    //denominator (знаменник)
       
        public static Fraction operator +(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down + first.down * second.up;
            f.down = first.down * second.down;
            return f;
        }
        public static Fraction operator -(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down - first.down * second.up;
            f.down = first.down * second.down;
            return f;
        }
        public static Fraction operator *(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.up;
            f.down = first.down * second.down;
            return f;
        }
        public static Fraction operator /(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down;
            f.down = first.down * second.up;
            return f;
        }
        public static bool operator ==(Fraction first, Fraction second)
        {
            return first.up / first.down == second.up / second.down;
        }
        public static bool operator !=(Fraction first, Fraction second)
        {
            return first.up / first.down != second.up / second.down;
        }

    }
}
