using System;

namespace ConsoleApp2
{
    class Student
    {
        string surname;
        string name;
        string patronymic;
        int group;
        DateTime date;

        public string Surname
        {
            set => this.surname = value;
            private get => this.surname;
        }
        public string Name
        {
            set => this.name = value;
            private get => this.name;
        }
        public string Patronymic
        {
            set => this.patronymic = value;
            private get => this.patronymic;
        }
        int[] marks = new int[100];        //
        int[][] valuations = new int[3][];
        public int[][] Valuations
        {
            get => valuations;
        }

        
        public Student(string surname, string name, string patronymic, int group, DateTime date)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            this.date = date;
            valuations[0] = new int[100];
            valuations[1] = new int[100];
            valuations[2] = new int[100];

        }

        public void SetAdmin(int[] a)
        {
            int m;
            int i = 0;
            while (Int32.TryParse(Console.ReadLine(), out m) && m >0 && m < 13)
            {
                marks[i] = m;
                i++;
            }
            Console.WriteLine("All marks are displayed");
            Console.WriteLine($"There are displayed {i} marks");
           
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{marks[j]}  ");
            }
            

            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Student s = new Student("Borshch", "Taras", "Igorovich", 12, new DateTime(2000, 05, 28));
            s.SetAdmin(arr);




        }
            
    

    }




            
}
