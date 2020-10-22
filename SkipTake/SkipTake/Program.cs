using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkipTake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            IEnumerable<Teachers> teachers = Teachers.GetTeachers();
            //foreach (var item in teachers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------------");

            int numberItemsOnPage = 6;
            int numberPage;
            int startPageNumber = 0;

            while (true)
            {
                Console.Clear();
                int counter = 1;
                ConsoleKey key = ConsoleKey.Escape;

                do
                {
                    Console.Clear();
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        IEnumerable<Teachers> page1 = teachers.Skip(0).Take(6);
                        Console.WriteLine("------------------------------");
                        foreach (Teachers t in page1)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("------------------------------");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();

                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        IEnumerable<Teachers> page2= teachers.Skip(6).Take(6);
                        Console.WriteLine("------------------------------");
                        foreach (Teachers t in page2)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("------------------------------");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();

                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        IEnumerable<Teachers> page3 = teachers.Skip(12).Take(6);
                        Console.WriteLine("------------------------------");
                        foreach (Teachers t in page3)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("------------------------------");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();

                    if (counter == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    IEnumerable<Teachers> page4 = teachers.Skip(18).Take(6);
                        Console.WriteLine("------------------------------");
                        foreach (Teachers t in page4)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("------------------------------");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();

                    if (counter == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    IEnumerable<Teachers> page5 = teachers.Skip(24).Take(6);
                        Console.WriteLine("------------------------------");
                        foreach (Teachers t in page5)
                        {
                            Console.WriteLine(t);
                        }
                        Console.WriteLine("------------------------------");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();


                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    key = keyInfo.Key;
                
                    switch (key)    //обхід меню стрілочками
                    {
                        case (ConsoleKey)ConsoleKey.RightArrow:
                            {
                                if (counter < 5) { counter++; }
                                else { counter = 1; }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.LeftArrow:
                            {
                                if (counter > 1) { counter--; }
                                else { counter = 5; }
                                break;
                            }
                    }


                } while (key != ConsoleKey.Enter);

                Console.Clear();
            }


            

            


            //Console.WriteLine("Enter number of page");
            //int num = int.Parse(Console.ReadLine());
            //IEnumerable<Teachers> page = teachers.Skip(startPageNumber+numberItemsOnPage*num - numberItemsOnPage)
            //    .Take(numberItemsOnPage);
            //Console.WriteLine("------------------------------");
            //foreach (Teachers t in page)
            //{
            //    Console.WriteLine(t);
            //}
            //Console.WriteLine("------------------------------");

        }
    }
}
