using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Files2_TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<Student>));

            // Ініціалізація об"єктів - використав лише перший раз для створення файла json2.json
            //Student student1 = new Student("Стадник", "Іван", "ФМ-41");
            //Student student2 = new Student("Лукащук", "Софія", "ФТХ-12");
            //Student student3 = new Student("Поляхов", "Руслан", "ФІ-32");
            //Student student4 = new Student("Парнюк", "Єва", "МІ-15");
            //Student student5 = new Student("Босий", "Микола", "МФ-22");
            //Student student6 = new Student("Гоч", "Тамара", "УФ-11");
            //Student student7 = new Student("Адамс", "Саманта", "ЦПХ-10");
            //List<Student> allStudents = new List<Student>
            //    { student1, student2, student3, student4, student5, student6, student7 };

            // Десеріалізуємо об"єкти із файла json2.json
            List<Student> allStudents = null;
            using (FileStream fs = new FileStream(@"g:\step\json2.json", FileMode.OpenOrCreate))
            {
                allStudents = (List<Student>)dcjs.ReadObject(fs);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список студентів:");
            Console.ResetColor();
            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\n\nВведіть прізвище нового студента:");
            //Console.ResetColor();
            //string newSurname = Console.ReadLine();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Введіть ім\'я нового студента:");
            //Console.ResetColor();
            //string newName = Console.ReadLine();

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Введіть групу нового студента:");
            //Console.ResetColor();
            //string newGroup = Console.ReadLine();

            //Student newStudent = new Student(newSurname, newName, newGroup);
            //allStudents.Add(newStudent);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\nСписок після додавання нового студента:");
            //Console.ResetColor();
            //foreach (var student in allStudents)
            //{
            //    Console.WriteLine(student);
            //}





            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВведіть прізвище студента, якого потрібно видалити");
            Console.ResetColor();
            string deletedStudent = Console.ReadLine();





            for (int i = 0; i < allStudents.Count; i++)
            {
                if (allStudents[i].Surname == deletedStudent)
                {
                    allStudents.RemoveAt(i);
                    Console.WriteLine("Видалено нахєр!");
                    break;
                }
                else
                {
                    Console.WriteLine("Такого прізвища немає у списку!");
                }
            }





            //bool check = false;
            //while (!check)
            //{
            //    check = true;
            //    try
            //    {
            //        for (int i = 0; i < allStudents.Count; i++)
            //        {
            //            if (allStudents[i].Surname == deletedStudent)
            //            {
            //                allStudents.RemoveAt(i);
            //                //check = true;
            //            }
            //            else
            //            {
            //                throw new SurnameEx();
            //            }
            //        }
            //    }
            //    catch (SurnameEx ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        check = false;
            //        Console.WriteLine("Повторно введіть прізвище");
            //        deletedStudent = Console.ReadLine();
            //    }
            //}


            //Console.WriteLine("----------------------\n");
            //bool flag = false;
            //do
            //{
            //    try
            //    {

            //        Console.WriteLine("Введіть прізвище студента,якого треба видалити");
            //        string del = string.Empty;
            //        del = Console.ReadLine();

            //        for (int i = 0; i < allStudents.Count; i++)
            //        {
            //            if (allStudents[i].Surname == del)
            //            {
            //                allStudents.RemoveAt(i);
            //                flag = true;
            //            }
            //            else
            //            {
            //                throw new Exception();
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Такого прізвища немає у списку!");
            //    }
            //} while (!flag);




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНовий список студентів:");
            Console.ResetColor();
            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }

            using (FileStream fs = new FileStream(@"g:\step\json2.json", FileMode.Truncate))
            {
                dcjs.WriteObject(fs, allStudents);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nДані серіалізовано!");
            Console.ResetColor();
            
        }
    }
    class SurnameEx : ApplicationException
    {
        public override string Message => "Такого прізвища немає у списку!";
    }
}
