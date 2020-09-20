using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Fraction
    {
        public int up { set; get; }    //numerator (чисельник)
        public int down { set; get; }    //denominator (знаменник)
        public Fraction(int num, int den)
        {
            up = num;
            down = den;
        }
        public double Result ()
        {
            return (double)up / (double)down;
        }
        public Fraction()
        {

        }

        public void Show()
        {
            if (up==0 || down==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.Write("{0}/{1}", up, down);
            }
        }
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
            return first.Result() == second.Result();
        }
        public static bool operator !=(Fraction first, Fraction second)
        {
            return first.Result() != second.Result();
        }
        public static bool operator <(Fraction first, Fraction second)
        {
            return first.Result() < second.Result();
        }
        public static bool operator <=(Fraction first, Fraction second)
        {
            return first.Result() <= second.Result();
        }
        public static bool operator >(Fraction first, Fraction second)
        {
            return first.Result() > second.Result();
        }
        public static bool operator >=(Fraction first, Fraction second)
        {
            return first.Result() >= second.Result();
        }
        public static bool operator true(Fraction f)
        {
            return f.up < f.down ? true : false;
        }
        public static bool operator false(Fraction f)
        {
            return f.up > f.down ? false : true;
        }
    }
}
