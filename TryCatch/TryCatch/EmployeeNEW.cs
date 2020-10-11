//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace TryCatch
//{
//    class EmployeeNEW
//    {
//        public string surname;
//        public string name;
//        public string post;
//        public string contract;
//        public short salary;
//        public static Hashtable logbook;
//        public override string ToString()
//        {
//            return $"\nНомер договору: {contract}";
//            //\nСпівробітник: {surname}\nПосада: {post}\nОклад: {salary}\n";
//        }

//        public void ShowOnce()
//        {
//            //Console.WriteLine($"Номер договору: {contract}");
//            Console.WriteLine($"Співробітник: {surname} {name}");
//            Console.WriteLine($"Посада {post}");
//            Console.WriteLine($"Оклад {salary}");
//        }
//        public override int GetHashCode()
//        {
//            return ToString().GetHashCode();
//        }

//        static EmployeeNEW()
//        {
//            EmployeeNEW.logbook = new Hashtable();
//        }

//        public EmployeeNEW(string surname, string name, string post, short salary)
//        {
//            this.surname = surname;
//            this.name = name;
//            this.post = post;
//            this.salary = salary;
//        }

//        public static void ShowCollective()
//        {
//            Console.WriteLine("Список всіх працівників");

//            //foreach (var emp in collective.Keys)
//            //{
//            //        Console.WriteLine(emp);
//            //    //Console.Write($"{emp}:");
//            //    foreach (EmployeeNEW item in collective.Values)
//            //    {
//            //        item.ShowOnce();
//            //        //Console.Write($"{item} ");
//            //    }
//            //    Console.WriteLine("\n\n");
//            //}


//            //foreach (var emp in collective.Keys)
//            //{
//            //    Console.WriteLine(emp);
//            //}

//            //foreach (EmployeeNEW emp in collective.Values)
//            //{
//            //    emp.ShowOnce();
//            //}

//            //foreach (EmployeeNEW emp in collective.Keys)
//            //{
//            //    foreach (EmployeeNEW item in collective.Values)
//            //    {
//            //    Console.WriteLine($"{emp}: ");
//            //        item.ShowOnce();
//            //    }
//            //    Console.WriteLine();
//            //}

//            foreach (DictionaryEntry item in logbook)
//            {
//                Console.WriteLine(item.Key);
//                Console.WriteLine(item.Value);
//            }

//        }

//        public string Surname
//        {
//            get => surname;
//            set => surname = value;
//        }
//        public string Name
//        {
//            get => name;
//            set => name = value;
//        }

//        public string Post
//        {
//            get => post;
//            set => post = value;
//        }

//        public short Salary
//        {
//            get => salary;
//            set => salary = value;
//        }

//        public string ContractNumber
//        {
//            get => contract;
//            set => contract = value;
//        }
//    }
//}
