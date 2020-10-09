using System;
using System.Collections;
using System.Text;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            //Employee employee1 = new Employee("Коваль", "Петро", "сторож", 5000, "ВТО-16М2");
            //Employee employee2 = new Employee("Сайчин", "Тарас", "водій", 8000, "ВТО-16М3");

            //Employee.ShowLogBook();
            //Console.WriteLine();
            //employee1.ShowOnceEmployee();



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
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n\n\n\n\t* Додати нового співробітника");
                    Console.ResetColor();
                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Редагувати інформацію");
                    Console.ResetColor();
                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Вивести інформацію про співробітника");
                    Console.ResetColor();
                    if (counter == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Видалити співробітника");
                    Console.ResetColor();
                    if (counter == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Перегляд інформації про всіх співробітників");
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

                switch (counter)
                {
                    case 1:
                        {

                            Console.Write("Ведіть прізвище співробітника:  ");
                            string eSurname = Console.ReadLine();
                            Console.Write("Ведіть ім\'я співробітника:  ");
                            string eName = Console.ReadLine();
                            Console.Write("Ведіть займану посаду:  ");
                            string ePost = Console.ReadLine();
                            Console.Write("Ведіть встановлений оклад:  ");
                            short eSalary = short.Parse(Console.ReadLine());
                            Console.Write("Ведіть номер договору:  ");
                            string eContract = Console.ReadLine();
                            Employee emp = new Employee(eSurname, eName, ePost, eSalary, eContract);
                            Console.WriteLine("\n\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ведіть номер договору для пошуку співробітника:");
                            string eContract = Console.ReadLine();
                            foreach (DictionaryEntry de in Employee.logbook)
                            {
                                if (Employee.logbook.Contains(eContract))
                                {
                                    Employee.ShowOnceEmployee();
                                    Console.WriteLine("\n\nВиберіть пункт для редагування:");
                                    Console.WriteLine("(1) - прізвище");
                                    Console.WriteLine("(2) - ім\'я");
                                    Console.WriteLine("(3) - посада");
                                    Console.WriteLine("(4) - оклад");
                                    Console.WriteLine("(5) - договір");
                                    int choice = int.Parse(Console.ReadLine());
                                    switch (choice)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Введіть нове прізвище: ");
                                                string newSurname = Console.ReadLine();
                                                de.Key
                                                Employe.Surname = newSurname;
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Введіть нове ім\'я: ");
                                                string newName = Console.ReadLine();
                                                Employee.Name = newName;
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Введіть нову посаду: ");
                                                string newPost = Console.ReadLine();
                                                Employee.Post = newPost;
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.WriteLine("Введіть новий оклад: ");
                                                short newSalary = short.Parse(Console.ReadLine());
                                                Employee.Salary = newSalary;
                                                break;
                                            }
                                        case 5:
                                            {
                                                Console.WriteLine("Введіть нове номер договору: ");
                                                string newContract = Console.ReadLine();
                                                Employee.ContractNumber = newContract;
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                }
                            }
                            


                            break;
                        }
                    case 3:
                        {
                            Console.Write("Ведіть номер договору для пошуку співробітника:");
                            string eContract = Console.ReadLine();
                            if (Employee.logbook.Contains(eContract))
                            {
                                Employee.ShowOnceEmployee();
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Ведіть номер договору для пошуку та видалення співробітника:");
                            string eContract = Console.ReadLine();
                            if (Employee.logbook.Contains(eContract))
                            {
                                Employee.logbook.Remove(eContract);
                            }
                            Employee.ShowLogBook();
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Employee.ShowLogBook();
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





        }
    }
}
