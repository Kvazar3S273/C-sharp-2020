using Parking;
using System;
using System.Text;

namespace DeLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Parker parker = new Parker();       //створюємо екземпляр паркувальника
            //----
            Parker.parkerName = "";
            while (true)                        //виводимо меню
            {
                Console.Clear();
                int counter = 1;
                ConsoleKey key = ConsoleKey.Escape;
                do
                {
                    Console.Clear();
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.WriteLine("\n\n\n\n\t* Авторизація паркувальника");
                    Console.ResetColor();
                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\t* Поставити автомобіль на парковку");
                    Console.ResetColor();
                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine("\t* Випустити автомобіль по паркувальному місцю");
                    Console.ResetColor();
                    if (counter == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.WriteLine("\t* Інформація про заповненість парковки");
                    Console.ResetColor();
                    if (counter == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Перегляд статистики по проданих парко-годинах");
                    Console.ResetColor();
                    if (counter == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("\t* Вихід");
                    Console.ResetColor();

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    key = keyInfo.Key;

                    switch (key)    //обхід меню стрілочками
                    {
                        case (ConsoleKey)ConsoleKey.DownArrow:
                            {
                                if (counter < 6) { counter++; }
                                else { counter = 1; }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.UpArrow:
                            {
                                if (counter > 1) { counter--; }
                                else { counter = 6; }
                                break;
                            }
                    }
                } while (key != ConsoleKey.Enter);
                Console.Clear();
                if (Parker.parkerName != "" || counter == 1 || counter == 6)
                {
                    switch (counter)
                    {
                        case 1:
                            {
                                string pName;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Ведіть ім'я паркувальника:");
                                Console.ResetColor();
                                pName = Console.ReadLine();
                                Parker.parkerName = pName;
                                break;
                            }
                        case 2:
                            {
                                parker.AddCarToParking();
                                Console.WriteLine();
                                parker.ShowAllCars();
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"Ведіть номер місця (1-12): ");
                                Console.ResetColor();
                                try
                                {
                                    int place = int.Parse(Console.ReadLine());
                                    parker.DeleteCarFromParking(place);
                                    parker.ShowAllCars();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            {
                                parker.ParkingInfo();
                                parker.ShowAllCars();
                                Console.ReadKey();
                                break;
                            }
                        case 5:
                            {
                                parker.ParkingStatistic();
                                Console.ReadKey();
                                break;
                            }
                        case 6:
                            {
                                return;
                                break;
                            }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ви не авторизовані!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }
    }
}
