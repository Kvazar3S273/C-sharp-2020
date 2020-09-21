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
                Console.Write("0");
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
        //public static Fraction operator +(Fraction first, double d)
        //{
        //    Fraction f = new Fraction();
        //    f.up = first.up * second.down + first.down * second.up;
        //    f.down = first.down * second.down;
        //    return f;
        //}
        public Fraction DoubleToFraction(double d)
        {
            Fraction f = new Fraction();
            int dInt = (int)d;   //ціла частина
            int dDen = 100;  //знаменник дробової частини
            int dNum = (int)(d - dInt) * dDen;   //чисельник дробової частини
            f.up = dInt * dDen + dNum;
            f.down = dDen;
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
        public static Fraction operator *(Fraction first, int a)
        {
            Fraction f = new Fraction();
            f.up = first.up * a;
            f.down = first.down;
            return f;
        }
        public static Fraction operator *(int a, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = a * second.up;
            f.down = second.down;
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
