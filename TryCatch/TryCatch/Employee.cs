using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace TryCatch
{
    class Employee
    {
        static string _surname;           // прізвище
        static string _name;              // ім"я
        static string _post;              // посада
        static short _salary;             // оклад          
        static string _contractNumber;    // номер договору про прийом на роботу 
        public static Hashtable logbook;  // журнал обліку співробітників


        
        static Employee()
        {
            Employee.logbook = new Hashtable();
        }
        public Employee(string surname, string name, string post, short salary, string contractNumber)
        {
            _surname = surname;
            _name = name;
            _post = post;
            _salary = salary;
            _contractNumber = contractNumber;
            Employee.logbook.Add(_contractNumber, _surname);
            Console.WriteLine("Співробітника {0} {1} добавлено в журнал обліку", surname, name);
        }
        public static void ShowOnceEmployee()
        {
            Console.WriteLine("Співробітник {0} {1}", _surname, _name);
            Console.WriteLine("Займана посада - {0}", _post);
            Console.WriteLine("Оклад - {0}", _salary);
            Console.WriteLine("Номер договору - {0}", _contractNumber);
            Console.WriteLine();
        }
        public static void ShowLogBook()
        {
            Console.Clear();
            Console.WriteLine("Журнал обліку співробітників: ");
            foreach (DictionaryEntry item in logbook)
            {
                Console.WriteLine("Співробітник {0}, договір № {1}", item.Value, item.Key);
            }
            //foreach (DictionaryEntry item in Employee.logbook.Values)
            //{
            //    if(item is Employee)
            //    {
            //        Employee.ShowOnceEmployee();
            //    }
            //    Console.WriteLine();
            //}
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"\nНомер договору:\t\t{_contractNumber}\nСпівробітник:\t\t{_surname}\nПосада:\t{_post}\nОклад:\t\t{_salary}\n";
        }

        public static string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public static string Name
        {
            get => _name;
            set => _name = value;
        }

        public static string Post
        {
            get => _post;
            set => _post = value;
        }

        public static short Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public static string ContractNumber
        {
            get => _contractNumber;
            set => _contractNumber = value;
        }
    }
}
