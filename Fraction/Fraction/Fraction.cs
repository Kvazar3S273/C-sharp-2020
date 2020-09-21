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
        public double Result () //метод отримання результату ділення чисельника на знаменник
        {
            return (double)up / (double)down;
        }
        public Fraction()
        {

        }

        public void Show()      //метод виведення дробу у звичайному вигляді (чисельник/знаменник)
        {
            if (up==0 || down==0)
            {
                Console.Write("0"); //якщо чисельник або знаменник = 0, то виводимо нуль, як ціле число (не дробом)
            }
            else
            {
                Console.Write("{0}/{1}", up, down);
            }
        }
        
        //перевантаження оператора + для двох дробів
        public static Fraction operator +(Fraction first, Fraction second)  
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down + first.down * second.up;
            f.down = first.down * second.down;
            return f;
        }
        public Fraction DoubleToFraction(double d)  //метод для переведення десяткового дробу в звичайний
        {
            Fraction f = new Fraction();
            int dInt = (Int32)d;                    //ціла частина
            int dDen = 10;                          //знаменник дробової частини
            int dNum = (Int32)((d - dInt) * dDen);  //чисельник дробової частини
            f.up = dInt * dDen + dNum;              //шукаємо чисельник нового дробу
            f.down = dDen;                          //шукаємо знаменник нового дробу
            return f;                               //повертаємо дріб
        }
        
        //перевантаження оператора + для звичайного дробу і десяткового
        public static Fraction operator +(Fraction first, double d)
        {
            Fraction f = new Fraction();            //дріб, який буде повертатись
            Fraction fd = new Fraction();           //дріб, в який буде переведено десятковий дріб
            fd = fd.DoubleToFraction(d);            //переводимо десятковий дріб в звичайний
            f.up = first.up * fd.down + first.down * fd.up; //рахуємо чисельник
            f.down = first.down * fd.down;          //рахуємо знаменник
            return f;                               //повертаємо результат
        }

        //перевантаження оператора - для двох дробів
        public static Fraction operator -(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down - first.down * second.up;
            f.down = first.down * second.down;
            return f;
        }
        
        //перевантаження оператора * для двох дробів
        public static Fraction operator *(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.up;
            f.down = first.down * second.down;
            return f;
        }

        //перевантаження оператора * для дроба і цілого числа
        public static Fraction operator *(Fraction first, int a)
        {
            Fraction f = new Fraction();
            f.up = first.up * a;
            f.down = first.down;
            return f;
        }

        //перевантаження оператора * для цілого числа і дроба
        public static Fraction operator *(int a, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = a * second.up;
            f.down = second.down;
            return f;
        }

        //перевантаження оператора / для двох дробів
        public static Fraction operator /(Fraction first, Fraction second)
        {
            Fraction f = new Fraction();
            f.up = first.up * second.down;
            f.down = first.down * second.up;
            return f;
        }

        //перевантаження оператора == для двох дробів
        public static bool operator ==(Fraction first, Fraction second)
        {
            return first.Result() == second.Result();
        }

        //перевантаження оператора != для двох дробів
        public static bool operator !=(Fraction first, Fraction second)
        {
            return first.Result() != second.Result();
        }

        //перевантаження оператора < для двох дробів
        public static bool operator <(Fraction first, Fraction second)
        {
            return first.Result() < second.Result();
        }

        //перевантаження оператора <= для двох дробів
        public static bool operator <=(Fraction first, Fraction second)
        {
            return first.Result() <= second.Result();
        }

        //перевантаження оператора > для двох дробів
        public static bool operator >(Fraction first, Fraction second)
        {
            return first.Result() > second.Result();
        }

        //перевантаження оператора >= для двох дробів
        public static bool operator >=(Fraction first, Fraction second)
        {
            return first.Result() >= second.Result();
        }

        //перевантаження операторів істинності для дроба
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
