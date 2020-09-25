using System;
using System.Text;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello stupids!");

            Timer time = new Timer();
            Console.WriteLine($"Час заїзду на парковку: {time.GetTimeToParking()}");
            Console.WriteLine($"Час виїзду з парковки: {time.GetTimeFromParking()}");

            Console.WriteLine($"Оплачений час: {time.GetPayTime()}");
            Console.WriteLine($"Штрафний час: {time.GetOverdueTime()}");
            Console.WriteLine("\n\n");
            Timer time1 = new Timer();
            Console.WriteLine($"Час заїзду на парковку: {time1.GetTimeToParking()}");
            Console.WriteLine($"Час виїзду з парковки: {time1.GetTimeFromParking()}");

            Console.WriteLine($"Оплачений час: {time1.GetPayTime()}");
            Console.WriteLine($"Штрафний час: {time1.GetOverdueTime()}");

        }
    }
}
