using System;
using System.Collections.Generic;
using System.Text;

namespace SkipTake
{
    class Teachers
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Teachers(string surname, string name, int salary)
        {
            Surname = surname;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return string.Format("{0,-12}{1,-12}{2,6:N0}", Surname, Name, Salary);
        }
        public static List<Teachers> GetTeachers()
        {
            Teachers t1 = new Teachers("Стадник", "Іван", 10500);
            Teachers t2 = new Teachers("Лукащук", "Софія", 11200);
            Teachers t3 = new Teachers("Поляхов", "Руслан", 15000);
            Teachers t4 = new Teachers("Парнюк", "Єва", 12000);
            Teachers t5 = new Teachers("Босий", "Микола", 11000);
            Teachers t6 = new Teachers("Гоч", "Тамара", 13100);
            Teachers t7 = new Teachers("Адамс", "Саманта", 9900);
            Teachers t8 = new Teachers("Ярощук", "Юрій", 11500);
            Teachers t9 = new Teachers("Ляховець", "Наталія", 14200);
            Teachers t10 = new Teachers("Калюх", "Віталій", 15050);
            Teachers t11 = new Teachers("Примачок", "Вадим", 14000);
            Teachers t12 = new Teachers("Давидюк", "Руслан", 16100);
            Teachers t13 = new Teachers("Бащук", "Роман", 11100);
            Teachers t14 = new Teachers("Яковчук", "Тарас", 9500);
            Teachers t15 = new Teachers("Голуб", "Василь", 18500);
            Teachers t16 = new Teachers("Василюк", "Гнат", 11300);
            Teachers t17 = new Teachers("Гнатюк", "Ігор", 15090);
            Teachers t18 = new Teachers("Дудас", "Олександр", 11010);
            Teachers t19 = new Teachers("Душенко", "Володимир", 13300);
            Teachers t20 = new Teachers("Головко", "Микола", 13100);
            Teachers t21 = new Teachers("Римавічюс", "Валентина", 9100);
            Teachers t22 = new Teachers("Данченко", "Михайло", 15100);
            Teachers t23 = new Teachers("Заулочний", "Віктор", 11200);
            Teachers t24 = new Teachers("Москалик", "Сергій", 15900);
            Teachers t25 = new Teachers("Сорока", "Віталій", 19000);
            Teachers t26 = new Teachers("Карнасевич", "Юлія", 10300);
            Teachers t27 = new Teachers("Каваців", "Ірина", 13100);
            Teachers t28 = new Teachers("Васюта", "Наталія", 10900);
            Teachers t29 = new Teachers("Олексін", "Олексій", 13500);
            Teachers t30 = new Teachers("Мартинюк", "Андрій", 13000);
            var allTeachers = new List<Teachers> { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, 
                                                   t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, 
                                                   t21, t22, t23, t24, t25, t26, t27, t28, t29, t30 };
            return allTeachers;
        }
    }
}
