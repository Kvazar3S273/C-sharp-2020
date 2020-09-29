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

            Car car = new Car();
            Ticket ticket = new Ticket(car);

            Console.WriteLine($"Автомобіль {car.GetBrand()} кольору {car.GetColor()} з номером {car.GetNumber()}");
            Console.WriteLine($"Час заїзду на парковку: {car.GetTimer().GetTimeToParking()}");
            Console.WriteLine($"Час виїзду з парковки: {car.GetTimer().GetTimeFromParking()}");
            Console.WriteLine($"Оплачений час: {car.GetTimer().GetPayTime()}");
            Console.WriteLine($"Штрафний час: {car.GetTimer().GetOverdueTime()}");
            Console.WriteLine("\n\n");

            ticket.ShowTicket();

            //Timer time1 = new Timer();
            //Console.WriteLine($"Час заїзду на парковку: {time1.GetTimeToParking()}");
            //Console.WriteLine($"Час виїзду з парковки: {time1.GetTimeFromParking()}");

            //Console.WriteLine($"Оплачений час: {time1.GetPayTime()}");
            //Console.WriteLine($"Штрафний час: {time1.GetOverdueTime()}");

        }
    }
}
