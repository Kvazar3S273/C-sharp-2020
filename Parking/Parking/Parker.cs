using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Parker
    {
        public static string parkerName;
        ParkingBook pBook = ParkingBook.GetInstance();  //створюємо екземпляр паркувальниї книги

        public void ViewFullStatistic()     //отримати повну статистику
        {
            pBook.FullStatistic();
        }
        public bool AddCarToParking()       //додати машину на парковку
        {
            if (pBook.ParkingNotFull())
            {
                Car car = new Car();
                pBook.AddCar(car);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Авто {car.GetBrand()} кольору {car.GetColor()} з ДН {car.GetNumber()} поставлено на парковку");
                Console.WriteLine($"Наперед було оплачено часу: {car.GetTimer().PayTime}");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Парковка заповнена! Вільних місць немає!");
                Console.ResetColor();
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

        public void ParkingStatistic()
        {
            pBook.FullStatistic();
        }

        public void DeleteCarFromParking(int place)     //видалити машину з парковки
        {
            Car car = pBook.DelCar(place);
            if (car == null)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Такого авто немає на парковці!");
                Console.ResetColor();
                return;
            }
            Ticket ticket = new Ticket(car);
            ticket.ShowTicket();
            pBook.AddToTicket(ticket);
        }

        public void ShowAllCars()           //показати список машин на парковці
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Паркувальник: {Parker.parkerName}");
            Console.ResetColor();
        }
    }
}