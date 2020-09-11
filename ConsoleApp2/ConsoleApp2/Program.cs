using System;
using System.Text;

namespace ConsoleApp2
{
    class Student
    {
        string surname;                     //прізвище
        string name;                        //ім"я
        string patronymic;                  //по-батькові
        int group;                          //номер групи
        DateTime b_day;                      //дата народження
        //--------
        public string Surname               //властивість прізвища
        {
            set => this.surname = value;
            get => this.surname;
        }
        public string Name                  //властивість імені
        {
            set => this.name = value;
            get => this.name;
        }
        public string Patronymic            //властивість по-батькові
        {
            set => this.patronymic = value;
            get => this.patronymic;
        }
        
        int[] marks = new int[100];         //масив оцінок по одному предмету
        int[][] valuations = new int[3][];  //масив всіх оцінок
        
        public int[][] Valuations           //властивість масиву оцінок
        {
            get => valuations;
        }

        public int Group
        {
            set => this.group = value;
            get => this.group; 
        }

        //конструктор класу Студента
        public Student(string surname, string name, string patronymic, int group, DateTime b_day)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            this.b_day = b_day;
            valuations[0] = new int[100];
            valuations[1] = new int[100];
            valuations[2] = new int[100];
        }

        public void SetAdmin(int[] a)       //заповнення масиву оцінок з адмінки
        {
            int m;
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Через ЕНТЕР введіть всі оцінки з Адміністрування (від 1 до 12)");
            Console.ResetColor();
            while (Int32.TryParse(Console.ReadLine(), out m) && m >0 && m < 13)
            {
                marks[i] = m;
                valuations[0][i] = marks[i];
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВсі оцінки з Адміністрування виставлені");
            Console.WriteLine($"Було виставлено {i} оцінок:\n");
            Console.ResetColor();
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{marks[j]}  ");
            }
            Console.WriteLine();
        }
        public void SetDesign(int[] a)      //заповнення масиву оцінок з дизайну
        {
            int m;
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nЧерез ЕНТЕР введіть всі оцінки з Дизайну (від 1 до 12)");
            Console.ResetColor();
            while (Int32.TryParse(Console.ReadLine(), out m) && m > 0 && m < 13)
            {
                marks[i] = m;
                valuations[1][i] = marks[i];
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВсі оцінки з Дизайну виставлені");
            Console.WriteLine($"Було виставлено {i} оцінок\n");
            Console.ResetColor();
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{marks[j]}  ");
            }
            Console.WriteLine();
        }
        public void SetDev(int[] a)         //заповнення масиву оцінок з програмування
        {
            int m;
            int i = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nЧерез ЕНТЕР введіть всі оцінки з Програмування (від 1 до 12)");
            Console.ResetColor();
            while (Int32.TryParse(Console.ReadLine(), out m) && m > 0 && m < 13)
            {
                marks[i] = m;
                valuations[2][i] = marks[i];
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВсі оцінки з Програмування виставлені");
            Console.WriteLine($"Було виставлено {i} оцінок\n");
            Console.ResetColor();
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{marks[j]}  ");
            }
            Console.WriteLine();
        }

        public double AvgAdmin              //середній бал з адмінки
        {
            get
            {
                int sum = 0;                //сума всіх оцінок
                int num = 0;                //кількість оцінок з діапазона 1..12 (не враховуємо нульові значення)
                double avg;                 //середній бал
                for (int i = 0; i < valuations[0].Length; i++)
                {
                    sum += valuations[0][i];
                    if (valuations[0][i] != 0)
                    {
                        num++;
                    }
                }
                if (num != 0)               //перевіряємо чи були оцінки по даному предмету
                    avg = Math.Round((double)sum / (double)(num), 2);
                else avg = 0;               //якщо ні, то середній бал = 0 (щоб уникнути ділення на нуль)
                return avg;
            }
        }
        public double AvgDesign              //середній бал з дизайну
        {
            get
            {
                int sum = 0;                //сума всіх оцінок
                int num = 0;                //кількість оцінок з діапазона 1..12 (не враховуємо нульові значення)
                double avg;                 //середній бал
                for (int i = 0; i < valuations[1].Length; i++)
                {
                    sum += valuations[1][i];
                    if (valuations[1][i] != 0)
                    {
                        num++;
                    }
                }
                if (num != 0)               //перевіряємо чи були оцінки по даному предмету
                    avg = Math.Round((double)sum / (double)(num), 2);
                else avg = 0;               //якщо ні, то середній бал = 0 (щоб уникнути ділення на нуль)
                return avg;
            }
        }
        public double AvgDev              //середній бал з програмування
        {
            get
            {
                int sum = 0;                //сума всіх оцінок
                int num = 0;                //кількість оцінок з діапазона 1..12 (не враховуємо нульові значення)
                double avg;                 //середній бал
                for (int i = 0; i < valuations[2].Length; i++)
                {
                    sum += valuations[2][i];
                    if (valuations[2][i] != 0)
                    {
                        num++;
                    }
                }
                if (num != 0)               //перевіряємо чи були оцінки по даному предмету
                    avg = Math.Round((double)sum / (double)(num), 2);
                else avg = 0;               //якщо ні, то середній бал = 0 (щоб уникнути ділення на нуль)
                return avg;
            }
        }
        public double AVG
        {
            get
            {
                double sum_all = 0;
                int count = 0;
                if (AvgAdmin != 0)          //перевіряємо чи були оцінки по предмету
                    count++;                //рахуємо лічильник кількості предметів, по яких були оцінки
                if (AvgDesign != 0)
                    count++;
                if (AvgDev != 0)
                    count++;
                if (AvgAdmin == 0 && AvgDesign == 0 && AvgDev == 0) //якщо з жодного предмету немає оцінок, то уникаємо 
                    count = 1;                                      //ділення на нуль
                sum_all = AvgAdmin + AvgDesign + AvgDev;
                double avg = Math.Round(sum_all / count, 2);
                return avg;
            }
        }

        public string Full_name
        {
            get
            {
                string full_name = this.surname + ' ' + this.name + ' ' + this.patronymic;
                return full_name;
            }
        }

        public int Age(DateTime b_day)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - b_day.Year;
            if (b_day > now.AddYears(-age)) age--;
            return age;
        }
        public void ClearMarks()
        {
            for (int i = 0; i < valuations.Length; i++)
            {
                for (int j = 0; j < valuations[i].Length; j++)
                {
                    if(valuations[i][j]!=0)
                    {
                        valuations[i][j] = 0;
                    }
                }
            }
        }
        public void Show(Student st)
        {
            Console.WriteLine($"\n\nПІБ студента: {st.Full_name}");
            Console.WriteLine($"Група: {st.Group}");
            Console.WriteLine($"День народження: {st.b_day}");
            Console.WriteLine($"Вік: повних {st.Age(b_day)} років\n");
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("              Оцінки з предметів");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\nАдміністрування:");
            for (int i = 0; i < valuations[0].Length; i++)
            {
                if(valuations[0][i]!=0)
                    Console.Write($"{valuations[0][i]}  ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nСередній бал з Адміністрування: {st.AvgAdmin}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("\nДизайн:");
            for (int i = 0; i < valuations[1].Length; i++)
            {
                if (valuations[1][i] != 0)
                    Console.Write($"{valuations[1][i]}  ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nСередній бал з Дизайну: {st.AvgDesign}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("\nПрограмування:");
            for (int i = 0; i < valuations[2].Length; i++)
            {
                if (valuations[2][i] != 0)
                    Console.Write($"{valuations[2][i]}  ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nСередній бал з Програмування: {st.AvgDev}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nСередній бал з з усіх предметів: {st.AVG}");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr = new int[100];
            DateTime birth = new DateTime(2000,2,12);
            Student s = new Student("Борщ", "Тарас", "Ігорович", 12, birth);
            s.SetAdmin(arr);
            s.SetDesign(arr);
            s.SetDev(arr);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=============================================");
            Console.ResetColor();
            s.Show(s);
            Console.WriteLine("Зміна групи. Введіть номер нової групи");
            int new_group;
            while (!Int32.TryParse(Console.ReadLine(), out new_group) || new_group <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Непрвильно введене значення!");
                Console.ResetColor();
            }
            Console.ResetColor();

            s.Group = new_group;
            s.Show(s);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Видалити всі оцінки з усіх предметів? Натисніть (0), якщо згідні");
            Console.ResetColor();
            int key = int.Parse(Console.ReadLine());
            if (key == 0)
                s.ClearMarks();
            s.Show(s);

            Console.WriteLine();
        }
    }
}
