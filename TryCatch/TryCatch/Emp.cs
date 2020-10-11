using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TryCatch
{
    class Emp
    {
        public static Hashtable logbook;
        private string name;
        private string surname;
        private string post;
        private short salary;
        private string contract;

        static Emp()
        {
            Emp.logbook = new Hashtable();
        }

        


        public Emp(string name, string surname, string post, short salary, string contract)
        {
            this.surname = surname;
            this.post = post;
            
            char[] digits = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                                        '.', ',', '!', '?', ' ',
                                        '/', '*', '+', '-' };
            bool check = false;
            this.name = name;


            while (!check)
            {
                Console.Clear();
                check = true;
                try
                {
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (this.name.Contains(digits[i]))
                        {
                            throw new NameEx();
                        }
                    }

                    
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (this.surname.Contains(digits[i]))
                        {
                            throw new SurnameEx();
                        }
                    }

                }
                
                catch (SurnameEx ex)
                {
                    Console.WriteLine(ex.Message);
                    check = false;
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Повторно введіть прізвище");
                    this.surname = Console.ReadLine();
                }
                catch (NameEx ex)
                {
                    Console.WriteLine(ex.Message);
                    check = false;
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Повторно введіть ім\'я");
                    this.name = Console.ReadLine();
                }
            }

            this.salary = salary;

            this.contract = contract;

            Emp.logbook.Add(this.contract, this);
            Console.WriteLine($"Працівника {name} добавлено в книгу обліку");
            Console.ReadKey();
        }

        public void ShowOnceEmp()
        {
            Console.WriteLine("Співробітник");
            Console.WriteLine("{0} {1}", surname, name);
            Console.WriteLine("Посада: {0}", post);
            Console.WriteLine("Оклад: {0}", salary);
            Console.WriteLine("Номер договору: {0}", contract);
            Console.WriteLine();
        }

        public string Surname
        {
            get => this.surname;
            set => this.surname = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public string Post
        {
            get => this.post;
            set => this.post = value;
        }

        public short Salary
        {
            get => this.salary;
            set => this.salary = value;
        }

        public string Contract
        {
            get => this.contract;
            set => this.contract = value;
        }

        public static void ShowLogBook()
        {
            Console.Clear();
            Console.WriteLine("Список всіх працівників");
            foreach (var emp in Emp.logbook.Values)
            {
                if (emp is Emp)
                {
                    ((Emp)emp).ShowOnceEmp();
                }
            }
        }

        public static void DeleteFromJournal()
        {
            Emp.ShowLogBook();
            string code = "";
            Console.WriteLine("Введіть номер договору для видалення");
            Console.ReadKey();
            code = Console.ReadLine();

            try
            {
                if (!Emp.logbook.Contains(code))
                {
                    throw new Exception("Працівника за таким номером договору не існує!");
                }
                Emp.logbook.Remove(code);
            }
            catch (Exception ex)
            {
                if (Emp.logbook.Count == 0)
                {
                    Console.WriteLine("Книга обліку порожня!");
                    return;
                }
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }


    class NameEx : ApplicationException
    {
        public override string Message => "Ім\'я не може містити цифр або символів!";
    }

    class SurnameEx : ApplicationException
    {
        public override string Message => "Прізвище не може містити цифр або символів!";
    }

    class SalaryEx : ApplicationException
    {
        public override string Message => "Оклад може містити тільки ціле число в розумних межах!";
    }
}