using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    class LogBook
    {
        string surname;           // прізвище
        string name;              // ім"я
        string contractNumber;    // номер договору про прийом на роботу 
        
        private static LogBook logBook = new LogBook();
        public LogBook()
        {

        }

        private const int size = 10;                            // кількість працівників - 10 чоловік
        private int numEmployee = 0;                            // лічильник кількості працівників
        private Employee[] employees = new Employee[size];      // масив працівників

        public int GetSize()
        {
            return size;
        }
        public string GetContractNumber(string contractN)
        {
            if (contractN == this.contractNumber)
            {
                return this.contractNumber;
            }
            return null;
        }
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

        public Employee FindEmployee(string contractN)
        {
            int num = Array.IndexOf(employees, GetContractNumber(contractN));
            Employee emp = employees[num];
            return emp;
        }

        public Employee FireEmployee(string contractN)  // звільнити працівника
        {
            int num = Array.IndexOf(employees, GetContractNumber(contractN));
            if (employees[num] == null)
            {
                return null;
            }
            if (num >= 0 && num < size)
            {
                Employee emp = employees[num];
                employees[num] = null;
                numEmployee--;
                return emp;
            }
            return null;
        }

        public void Show()
        {
            foreach (var emp in employees)
            {
                Console.Write("{0} - {1} {2}", emp.ContractNumber, emp.Surname, emp.Name);
                Console.WriteLine();
            }
        }
        public static LogBook GetInstance()     //отримати екземпляр журнала (для сінглтона)
        {
            if (logBook == null)
            {
                logBook = new LogBook();
            }
            return logBook;
        }

        public Employee this[int a]
        {
            get
            {
                return this.employees[a];
            }
        }

    }
}
