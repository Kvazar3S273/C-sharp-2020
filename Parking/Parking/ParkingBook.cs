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

        private const int size = 12;
        private int numCars = 0;    
        private List<Ticket> tickets = new List<Ticket>();
        private Car[] cars = new Car[size];

        public bool ParkingNotFull()   
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

        public void AddCar(Car car) 
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
        public void AddToTicket(Ticket ticket) 
        {
            tickets.Add(ticket);
        }

        public Car DelCar(int place)    
        {
            place--;
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

        public double GetAllOverPay()  
        {
            double allOverPay = 0;
            foreach (var tik in tickets)
            {
                allOverPay += tik.GetOverpay();
            }
            return allOverPay;
        }

        public void ParkingInfo() 
        {
            Console.WriteLine($"Кількість вільних місць - {size - numCars} з {size}");
            Console.WriteLine($"Кількість зайнятих місць - {numCars} з {size}");
        }

        public void FullStatistic()
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

        public static ParkingBook GetInstance()
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