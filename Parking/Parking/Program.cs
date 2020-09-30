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
            ticket.ShowTicket();

            Car car1 = new Car();
            Ticket ticket1 = new Ticket(car1);
            ticket1.ShowTicket();
        }
    }
}
