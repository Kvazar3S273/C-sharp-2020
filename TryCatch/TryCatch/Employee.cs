using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch
{
    class Employee
    {
        string surname;           // прізвище
        string name;              // ім"я
        string post;              // посада
        short salary;             // оклад          
        string contractNumber;    // номер договору про прийом на роботу 
        static LogBook logBook = LogBook.GetInstance();   // журнал обліку
        private Employee[] employees = new Employee[logBook.GetSize()];      // масив працівників

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public short Salary { get; set; }
        public string ContractNumber { get; set; }

        //public string GetSurname()
        //{
        //    return this.surname;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
        //public string GetPost()
        //{
        //    return this.post;
        //}
        //public short GetSalary()
        //{
        //    return this.salary;
        //}
        //public string GetContractNumber()
        //{
        //    return this.contractNumber;
        //}
        public Employee(string surname, string name, string post, short salary, string contractNumber)
        {
            this.surname = surname;
            this.name = name;
            this.post = post;
            this.salary = salary;
            this.contractNumber = contractNumber;
        }
        public void ShowOnceEmployee()
        {
            //Console.WriteLine("Співробітник {0} {1}",GetSurname(), GetName());
            //Console.WriteLine("Займана посада - {0}", GetPost());
            //Console.WriteLine("Оклад - {0}", GetSalary());
            //Console.WriteLine("Номер договору - {0}", GetContractNumber());

            Console.WriteLine("Співробітник {0} {1}", Surname, Name);
            Console.WriteLine("Займана посада - {0}", Post);
            Console.WriteLine("Оклад - {0}", Salary);
            Console.WriteLine("Номер договору - {0}", ContractNumber);
        }
    }
}
