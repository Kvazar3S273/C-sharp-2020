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

            // Ініціалізація об"єктів
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

            // Списки
            // Списки група-викладачі
            g1.Teachers = new List<Teachers> { t1, t2, t3, t4, t7 };
            g2.Teachers = new List<Teachers> { t2, t4, t5, t6, t7 };
            g3.Teachers = new List<Teachers> { t1, t2, t3, t7 };
            g4.Teachers = new List<Teachers> { t2, t3, t4, t6 };
            g5.Teachers = new List<Teachers> { t2, t5, t6 };
            g6.Teachers = new List<Teachers> { t1, t4, t5 };
            g7.Teachers = new List<Teachers> { t2, t5, t6, t7 };
            g8.Teachers = new List<Teachers> { t2, t4, t6};
            g9.Teachers = new List<Teachers> { t1, t2, t4, t7 };
            g10.Teachers = new List<Teachers> { t2, t3, t5, t6 };

            // Списки група-факультет
            g1.Faculties = new List<Faculties> { f1, f2 };
            g2.Faculties = new List<Faculties> { f1, f2, f3 };
            g3.Faculties = new List<Faculties> { f1, f2 };
            g4.Faculties = new List<Faculties> { f2, f3 };
            g5.Faculties = new List<Faculties> { f1, f3 };
            g6.Faculties = new List<Faculties> { f1, f2, f3 };
            g7.Faculties = new List<Faculties> { f1, f3 };
            g8.Faculties = new List<Faculties> { f1, f2 };
            g9.Faculties = new List<Faculties> { f2, f3 };
            g10.Faculties = new List<Faculties> { f1, f2, f3 };

            // Списки викладач-кафедра
            t1.Departments = new List<Departments> { d1, d3 };
            t2.Departments = new List<Departments> { d2 };
            t3.Departments = new List<Departments> { d1, d2, d3, d4 };
            t4.Departments = new List<Departments> { d1, d2 };
            t5.Departments = new List<Departments> { d1 };
            t6.Departments = new List<Departments> { d1, d3, d4 };
            t7.Departments = new List<Departments> { d2, d4 };

            // Списки кафедра-група
            d1.Groups = new List<Groups> { g1, g2, g3, g5, g6, g9, g10 };
            d2.Groups = new List<Groups> { g2, g4, g5, g8, g10 };
            d3.Groups = new List<Groups> { g1, g3, g4, g5, g7, g8, g9 };
            d4.Groups = new List<Groups> { g1, g3, g4, g6, g7, g10 };
            
            // Списки факультет-кафедра
            f1.Departments = new List<Departments> { d1, d2, d3 };
            f2.Departments = new List<Departments> { d1, d3, d4 };
            f3.Departments = new List<Departments> { d2, d4 };


            //1.Вывести все возможные пары строк преподавателей и групп.

            var report1 = allGroups.SelectMany(g => g.Teachers.Select(t => new { група = g, вчитель = t }));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Групи та викладачі, які в них читають");
            Console.ResetColor();
            foreach (var x in report1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //2.Вывести названия факультетов, фонд финансирования кафедр которых превышает фонд финансирования факультета.

            var report2 = allFaculties.Where(f => f.Finance < f.Departments.Sum(d => d.Finance)).Select(f => f.FacultieName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: факультети, фонд фінансування кафедр яких перевищує фонд фінансування факультету");
            Console.ResetColor();
            foreach (var x in report2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //3.Вывести имена и фамилии преподавателей, которые читают лекции у группы “P107”.

            var report3 = allGroups.Where(g => g.GroupName == "P107").SelectMany(g => g.Teachers).Select(t => t);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Прізвища і імена викладачів, які читають лекції у групі Р107");
            Console.ResetColor();
            foreach (var x in report3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //4.Вывести фамилии преподавателей и названия факультетов на которых они читают лекции.

            var report4 = allTeachers.SelectMany(t =>
                allFaculties.Where(f => f.Departments.Any(d => t.Departments.Contains(d)))
                .Select(f => new { викладач = t, факультет = f }))
                .Select(t => t);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Прізвища викладачів і назви факультетів, на яких вони читають лекції");
            Console.ResetColor();
            foreach (var x in report4)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //5.Вывести названия кафедр и названия групп, которые к ним относятся.

            var report5 = allDepartments.SelectMany(d => d.Groups.Select(g => new { кафедра = d, група = g }));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Назви кафедр і назви груп, які до них відносяться");
            Console.ResetColor();
            foreach (var x in report5)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //6.Вывести названия кафедр, на которых читает преподаватель “Samantha Adams”.

            var report6 = allTeachers.Where(t => t.Surname == "Адамс").SelectMany(d => d.Departments).Select(d => d);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Назви кафедр, на яких читає Саманта Адамс");
            Console.ResetColor();
            foreach (var x in report6)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //7.Вывести названия групп, которые относятся к факультету “Computer Science”.

            var report7 = allGroups.SelectMany(x => x.Faculties.Where(y => y.FacultieName == "ІТ освіта")
                .Select(t => new { група = x.GroupName }));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Назви груп, які відносяться до факультету ІТ освіта");
            Console.ResetColor();
            foreach (var x in report7)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");

            //8.Вывести названия групп 5 - го курса, а также название факультетов, к которым они относятся.

            var report8 = allGroups.Where(x=>x.Course==5)
                .SelectMany(g => g.Faculties.Select(f => new { група = g, факультет = f }));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вибірка: Групи 5-го курсу та факультети, до яких вони відносяться");
            Console.ResetColor();
            foreach (var x in report8)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("===================================================================\n");
        }
    }
}
