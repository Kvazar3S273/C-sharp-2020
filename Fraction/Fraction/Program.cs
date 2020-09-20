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
            Console.WriteLine("Введіть чисельник і через ентер знаменник");
            Int32.TryParse(Console.ReadLine(), out num);
            Int32.TryParse(Console.ReadLine(), out den);
            Console.WriteLine("{0}/{1}", num, den);
        }
    }
}
