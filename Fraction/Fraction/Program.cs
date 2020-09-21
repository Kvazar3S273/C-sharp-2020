using System;
using System.Text;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть чисельник і через ентер знаменник для першого дробу");
            int num1 = int.Parse(Console.ReadLine());
            int den1 = int.Parse(Console.ReadLine());

            Fraction f1 = new Fraction(num1, den1);
            Console.Write("Ви ввели дріб ");
            f1.Show();
            if (f1)
            {
                Console.WriteLine("\nЦе правильний дріб (чисельник менший за знаменник)");
            }
            else
            {
                Console.WriteLine("\nЦе неправильний дріб (чисельник більший за знаменник)");
            }
            Console.WriteLine();

            Console.WriteLine("Введіть чисельник і через ентер знаменник для другого дробу");
            int num2 = int.Parse(Console.ReadLine());
            int den2 = int.Parse(Console.ReadLine());

            Fraction f2 = new Fraction(num2, den2);
            Console.Write("Ви ввели дріб ");
            f2.Show();
            if (f2)
            {
                Console.WriteLine("\nЦе правильний дріб (чисельник менший за знаменник)");
            }
            else
            {
                Console.WriteLine("\nЦе неправильний дріб (чисельник більший за знаменник)");
            }
            Console.WriteLine();

            Fraction f = new Fraction();
            f = f1 + f2;
            Console.Write("\nСума двох дробів = ");
            f.Show();

            f = f1 - f2;
            Console.Write("\nРізниця двох дробів = ");
            f.Show();

            f = f1 * f2;
            Console.Write("\nДобуток двох дробів = ");
            f.Show();

            f = f1 / f2;
            Console.Write("\nЧастка двох дробів = ");
            f.Show();
            if (f1 < f2)
            {
                Console.Write("\nПерший дріб менший за другий  ");
                f1.Show();
                Console.Write(" < ");
                f2.Show();
            }
            else if (f1 > f2)
            {
                Console.Write("\nПерший дріб більший за другий  ");
                f1.Show();
                Console.Write(" > ");
                f2.Show();
            }
            else if (f1 == f2)
            {
                Console.Write("\nДроби рівні  ");
                f1.Show();
                Console.Write(" = ");
                f2.Show();
            }
            Console.WriteLine();

           
            Console.WriteLine("\n\nЗавдання з умови задачі:\n");
            Fraction ff = new Fraction(3, 4);
            int a = 10;
            Fraction f11 = ff * a;
            Console.Write("Результат добутку 3/4 * 10 = ");
            f11.Show();
            Console.WriteLine();
            Fraction f22 = a * ff;
            Console.Write("Результат добутку 10 * 3/4 = ");
            f22.Show();
            Console.WriteLine();
            double d = 1.5;
            Fraction f33 = ff + d;
            Console.Write("Результат додавання 3/4 + 1,5 = ");
            f33.Show();

            Console.WriteLine();
        }
    }
}
