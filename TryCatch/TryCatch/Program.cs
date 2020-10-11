using System;
using System.Collections;
using System.Text;

namespace TryCatch
{
    class Program
    {
        //string surname;
        //string name;
        //string post;
        //string contract;
        //short salary;

        //static Hashtable collective = new Hashtable
        //{
        //    { 
        //        new EmployeeNEW { contract="ID1625"}, 
        //        new EmployeeNEW { surname="Антонюк", name="Андрій", post="автомеханік", salary=1000 } },
        //    {
        //        new EmployeeNEW { contract="ID1626"},
        //        new EmployeeNEW { surname="Борисюк", name="Богдан", post="будівельник", salary=2000 } },
        //    {
        //        new EmployeeNEW { contract="ID1627"},
        //        new EmployeeNEW { surname="Вітрук", name="Василь", post="водій", salary=3000 } },
        //    {
        //        new EmployeeNEW { contract="ID1628"},
        //        new EmployeeNEW { surname="Гордійчук", name="Геннадій", post="геолог", salary=4000 } }
        //};

        //static Hashtable collective = new Hashtable();




        //static void SetSalary(string contract, short salary)
        //{
        //    Console.WriteLine($"Зарплату працівника, що працює по договору {contract} змінено на {salary}");
        //    foreach (EmployeeNEW item in collective.Keys)
        //    {
        //        if (item.contract == contract)
        //        {
        //            item.Salary = salary;
        //            //(collective[item] as Hashtable)  //Add(salary);
        //        }
        //    }
        //}
        //public static short CheckSalary(string salary)
        //{
        //    //short checksalary;
        //    //bool check;
        //    //check = false;
        //    //while (!check)
        //    //{
        //      //  check = true;
        //        Console.Clear();
        //        //try
        //        //{
        //            short checksalary;
        //            while (!short.TryParse(salary, out checksalary)) 
        //            {
        //                Console.WriteLine("You entered incorrect value! Try again...");
        //            }
        //            //checksalary = _salary;
        //        //}
        //        /*catch (SalaryEx ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            check = false;
        //            Console.ReadKey();
        //            Console.Clear();
        //            Console.Write("Повторно введіть оклад");
        //            checksalary = short.Parse(Console.ReadLine());
        //        }*/
        //    //}
        //    return checksalary;
        //}

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
                string enterSalary = Console.ReadLine();
                short salary;
                while (!Int16.TryParse(enterSalary, out salary))
                {
                    Console.WriteLine("Ви ввели недопустиме значення! Спробуйте ще раз...");
                }

                Console.Write("Ведіть номер договору:  ");
                string eContract = Console.ReadLine();
                Emp emp = new Emp(eSurname, eName, ePost, salary, eContract);
                Console.WriteLine();
            }


            Emp.ShowLogBook();



        }
    }
}
