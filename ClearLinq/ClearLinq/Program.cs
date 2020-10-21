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

            // Init objects
            Teachers t1 = new Teachers("Стадник", "Іван", 10500);
            Teachers t2 = new Teachers("Лукащук", "Софія", 11200);
            Teachers t3 = new Teachers("Поляхов", "Руслан", 15000);
            Teachers t4 = new Teachers("Парнюк", "Єва", 12000);
            Teachers t5 = new Teachers("Босий", "Микола", 11000);
            Teachers t6 = new Teachers("Гоч", "Тамара", 13100);
            Teachers t7 = new Teachers("Адамс", "Саманта", 9900);

            var allTeachers = new List<Teachers> { t1, t2, t3, t4, t5, t6, t7 };

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

            var allGroups = new List<Groups> { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };

            Faculties f1 = new Faculties("ІТ освіта", 2000000);
            Faculties f2 = new Faculties("Адміністрування", 1000000);
            Faculties f3 = new Faculties("Дизайн", 1500000);

            var allFaculties = new List<Faculties> { f1, f2, f3 };

            Departments d1 = new Departments("Програмування", 500000);
            Departments d2 = new Departments("WEB дизайн", 700000);
            Departments d3 = new Departments("Комп\'ютерні мережі", 500000);
            Departments d4 = new Departments("Розробка баз даних", 500000);

            var allDepartments = new List<Departments> { d1, d2, d3, d4 };

            // Link objects
            // Init groups
            g1.Teachers = new List<Teachers> { t1, t2, t3 };
            g2.Teachers = new List<Teachers> { t2, t5, t7 };

            g1.Faculties = new List<Faculties> { f1 };
            g2.Faculties = new List<Faculties> { f1, f2 };

            // Init teachers
            t1.Departments = new List<Departments> { d1 };
            t2.Departments = new List<Departments> { d2 };

            // Init departments
            d1.Groups = new List<Groups> { g1, g2, g3 };
            
            // Init faculties
            f1.Departments = new List<Departments> { d1, d2, d3 };

            
            var report1 = allGroups.SelectMany(g => g.Teachers
                .Select(t => new { group = g, teacher = t }));
            Console.WriteLine("Report1");
            foreach (var x in report1)
            {
                Console.WriteLine(x);
            }

            //var report2 = allFaculties.Where(f => f.Finance < f.Departments.Sum(d => d.Finance))
            //    .Select(f => f.FacultieName);
            //Console.WriteLine("Report2");
            //foreach (var x in report2)
            //{
            //    Console.WriteLine(x);
            //}

            //var report3 = allGroups.Where(g => g.GroupName == "P107").SelectMany(g => g.Teachers)
            //    .Select(t => new { surname = t.Surname, name = t.Name });
            //Console.WriteLine("Report3");
            //foreach (var x in report3)
            //{
            //    Console.WriteLine(x);
            //}

            //var report4 = allTeachers.SelectMany(t =>
            //    allFaculties.Where(f => f.Departments.Any(d => t.Departments.Contains(d))).Select(f => new { f, t }))
            //    .Select();
        }
    }
}
