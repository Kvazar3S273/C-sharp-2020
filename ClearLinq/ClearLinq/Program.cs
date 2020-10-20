using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Teachers t1 = new Teachers("Стадник", "Іван", 10500);
            Teachers t2 = new Teachers("Лукащук", "Софія", 11200);
            Teachers t3 = new Teachers("Поляхов", "Руслан", 15000);
            Teachers t4 = new Teachers("Парнюк", "Єва", 12000);
            Teachers t5 = new Teachers("Босий", "Микола", 11000);
            Teachers t6 = new Teachers("Гоч", "Тамара", 13100);
            Teachers t7 = new Teachers("Адамс", "Саманта", 9900);

            List<Teachers> teachers = new List<Teachers>();
            teachers.Add(t1);
            teachers.Add(t2);
            teachers.Add(t3);
            teachers.Add(t4);
            teachers.Add(t5);
            teachers.Add(t6);
            teachers.Add(t7);

            Groups g1 = new Groups("P101", 1);
            Groups g2 = new Groups("P102", 1);
            Groups g3 = new Groups("P103", 2);
            Groups g4 = new Groups("P104", 2);
            Groups g5 = new Groups("P105", 3);
            Groups g6 = new Groups("P106", 3);
            Groups g7 = new Groups("P107", 4);
            Groups g8 = new Groups("P108", 4);
            Groups g9 = new Groups("P109", 5);
            Groups g10 = new Groups("P110", 5);

            List<Groups> groups = new List<Groups>();
            groups.Add(g1);
            groups.Add(g2);
            groups.Add(g3);
            groups.Add(g4);
            groups.Add(g5);
            groups.Add(g6);
            groups.Add(g7);
            groups.Add(g8);
            groups.Add(g9);
            groups.Add(g10);

            Faculties f1 = new Faculties("ІТ освіта", 2000000);
            Faculties f2 = new Faculties("Адміністрування", 1000000);
            Faculties f3 = new Faculties("Дизайн", 1500000);

            List<Faculties> faculties = new List<Faculties>();
            faculties.Add(f1);
            faculties.Add(f2);
            faculties.Add(f3);

            Departments d1 = new Departments("Програмування", 500000);
            Departments d2 = new Departments("WEB дизайн", 700000);
            Departments d3 = new Departments("Комп\'ютерні мережі", 500000);
            Departments d4 = new Departments("Розробка баз даних", 500000);
            
            List<Departments> departments = new List<Departments>();
            departments.Add(d1);
            departments.Add(d2);
            departments.Add(d3);
            departments.Add(d4);

            //foreach (var item in teachers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------");

            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------");

            //foreach (var item in faculties)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------");

            //foreach (var item in departments)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerable<Teachers> report1 = teachers.Where(x => x.Salary < 12000).Select(y => y);
            foreach (var x in report1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
