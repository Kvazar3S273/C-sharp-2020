using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    class LogBook
    {
        //string surname;           // прізвище
        //string name;              // ім"я
        //string contractNumber;    // номер договору про прийом на роботу 
        
        private static LogBook logBook = new LogBook();
        public LogBook()
        {

        }

        private const int size = 10;                            // кількість працівників - 10 чоловік
        private int numEmployee = 0;                            // лічильник кількості працівників
        private Employee[] employees = new Employee[size];      // масив працівників

        public bool StateNotFull()                // перевірка чи не забагато працівників
        {
            if (numEmployee == size)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddEmployee(Employee emp)   // додати нового працівника
        {
            if (StateNotFull())
            {
                for (int i = 0; i < size; i++)
                {
                    if (employees[i] == null)
                    {
                        employees[i] = emp;
                        numEmployee++;
                        return;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Штат працівників заповнений!");
                Console.ResetColor();
            }
        }

        public Employee FireEmployee(string contractN)  // звільнити працівника
        {
            //place--;                                
            //if (cars[place] == null)
            //{
            //    return null;
            //}
            //if (place >= 0 && place < size)
            //{
            //    Car car = cars[place];
            //    cars[place] = null;
            //    numCars--;
            //    return car;
            //}
            return null;
        }

        public static LogBook GetInstance()     //отримати екземпляр журнала (для сінглтона)
        {
            if (logBook == null)
            {
                logBook = new LogBook();
            }
            return logBook;
        }
    }
}
