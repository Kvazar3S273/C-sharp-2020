using System;
using System.Collections.Generic;

namespace Parking
{
    class ParkingBook
    {
        private static ParkingBook parkingBook = new ParkingBook();
        private ParkingBook()
        {

        }

        private const int size = 12;                            //розмір парковки - 12 місць
        private int numCars = 0;                                //лічильник кількості машин на парковці
        private List<Ticket> tickets = new List<Ticket>();      //список виписаних квитанцій
        private Car[] cars = new Car[size];                     //масив машин, присутніх на парковці

        public bool ParkingNotFull()                //перевірка чи не заповнена повністю парковка
        {
            if (numCars == size) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddCar(Car car)                 //додати машину на парковку
        {
            if (ParkingNotFull())
            {
                for (int i = 0; i < size; i++)
                {
                    if (cars[i] == null)
                    {
                        cars[i] = car;
                        numCars++;
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Парковка заповнена! Вільних місць немає!");
            }
        }
        public void AddToTicket(Ticket ticket)      //додати квитанцію
        {
            tickets.Add(ticket);
        }

        public Car DelCar(int place)                //видалити машину з парковки
        {
            place--;                                //зменшуємо число введеного місця, т.як нумерація йде з нуля
            if (cars[place] == null)
            {
                return null;
            }
            if (place >= 0 && place < size)
            {
                Car car = cars[place];              
                cars[place] = null;
                numCars--;
                return car;
            }
            return null;
        }

        public double GetAllOverPay()               //отримати всі штрафи
        {
            double allOverPay = 0;
            foreach (var tik in tickets)
            {
                allOverPay += tik.GetOverpay();
            }
            return allOverPay;
        }

        public void ParkingInfo()                   //інформація про вільні місця на парковці
        {
            Console.WriteLine($"Кількість вільних місць - {size - numCars} з {size}");
            Console.WriteLine($"Кількість зайнятих місць - {numCars} з {size}");
        }

        public void FullStatistic()                 //повна статистика по проданих парко-годинах і виписаних штрафах
        {
            int fullHours = 0;    
            int fullOverHours = 0;   
            int fullOverpay = 0;    

            foreach (var el in tickets)
            {
                fullHours += (int)(el.GetMinutesPayTime() / 60);
                fullOverHours += (int)(el.GetMinutesOverdueTime() / 60);
                fullOverpay += (int)el.GetOverpay();
            }

            Console.WriteLine($"Всього продано паркувальних годин: {fullHours}");
            Console.WriteLine($"Всього оштрафовано за простій в годинах: {fullOverHours}");
            Console.WriteLine($"Всього виписано штрафів: {fullOverpay} грн");
        }

        public int GetSize()                        
        {
            return size;
        }

        public static ParkingBook GetInstance()     //отримати екземпляр паркувальної книги (для сінглтона)
        {
            if (parkingBook == null) 
            {
                parkingBook = new ParkingBook(); 
            }
            return parkingBook;
        }

        public Car this[int a]                      
        {
            get
            {
                return this.cars[a];
            }
        }
    }
}