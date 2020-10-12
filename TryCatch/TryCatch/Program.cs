using System;
using System.Text;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            
            Console.WriteLine("Яку кількість працівників Ви хочете додати?");
            int col = int.Parse(Console.ReadLine());
            for (int i = 0; i < col; i++)
            {
                Console.Write("Ведіть прізвище співробітника:  ");
                string eSurname = Console.ReadLine();
                Console.Write("Ведіть ім\'я співробітника:  ");
                string eName = Console.ReadLine();
                Console.Write("Ведіть займану посаду:  ");
                string ePost = Console.ReadLine();
                
                Console.Write("Ведіть встановлений оклад:  ");
                short salary;
                while (!Int16.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Ви ввели недопустиме значення! Спробуйте ще раз...");
                }

                Console.Write("Ведіть номер договору:  ");
                string eContract = Console.ReadLine();
                Emp emp = new Emp(eSurname, eName, ePost, salary, eContract);
                Console.WriteLine();
            }

            Emp.ShowLogBook();
            Emp.DeleteFromLogBook();
        }
    }
}
