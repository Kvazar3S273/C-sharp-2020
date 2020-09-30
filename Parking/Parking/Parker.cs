using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parker
    {
        public static string parkerName;
        ParkingBook pBook = ParkingBook.GetInstance();

        public void ViewFullStatistic()   
        {
            pBook.FullStatistic();
        }
        public bool AddCarToParking() 
        {
            if (pBook.ParkingNotFull())
            {
                Car car = new Car();
                pBook.AddCar(car);
                Console.WriteLine($"Авто {car.GetBrand()} кольору {car.GetColor()} з ДН {car.GetNumber()} поставлено на парковку");
                Console.WriteLine($"Наперед було оплачено часу: {car.GetTimer().PayTime}");
                return true;
            }
            else
            {
                Console.WriteLine("Парковка заповнена! Вільних місць немає!");
                return false;
            }
        }

        public double GetAllOverPay()  
        {
            return pBook.GetAllOverPay();
        }

        public void ParkingInfo() 
        {
            pBook.ParkingInfo();
        }

        public void DeleteCarFromParking(int place)   
        {
            Car car = pBook.DelCar(place);
            if (car == null)
            {
                Console.WriteLine("Такого авто немає на парковці!");
                return;
            }
            Ticket ticket = new Ticket(car);
            ticket.ShowTicket();
            pBook.AddToTicket(ticket);
        }

        public void ShowAllCars()
        {
            Console.WriteLine("======================================================================================");
            Console.WriteLine("| Місце |    Марка    |  Колір  |  держ. номер   |     Час заїзду    | Оплачений час |");
            Console.WriteLine("======================================================================================");

            for (int i = 0; i < pBook.GetSize(); i++)
            {
                if (pBook[i] != null)
                {
                    Console.Write($"     {i + 1}     ");
                    Console.Write($"  {pBook[i].GetBrand()}\t");
                    Console.Write($"{pBook[i].GetColor()}\t");
                    Console.Write($"    {pBook[i].GetNumber()}   ");
                    Console.Write($"  {pBook[i].GetTimer().GetTimeToParking()}   ");
                    Console.Write($" {pBook[i].GetTimer().GetPayTime()} ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("======================================================================================");
            Console.WriteLine($"Паркувальник: {Parker.parkerName}");
        }
    }
}