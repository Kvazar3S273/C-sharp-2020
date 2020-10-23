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
            
            int skipps = 0;
            int numberItemsOnPage = 6;

            var collection = teachers.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    collection = teachers.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
                    if (collection.Count() <= 0)
                    {
                        skipps--;
                        break;
                    }

                    Console.WriteLine("------------------------------");
                    foreach (var item in collection)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n     <-  Сторiнка: " + (skipps + 1) + "  ->");
                    Console.ResetColor();
                    Console.WriteLine("\n      (ESC - щоб вийти)");

                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n        Do widzenia!");
                        Console.ResetColor();
                        return;
                    }
                } while (keyInfo.Key != ConsoleKey.LeftArrow && keyInfo.Key != ConsoleKey.RightArrow || keyInfo.Key==ConsoleKey.Escape);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                    {
                        if (skipps < teachers.Count() / 5)
                        {
                            skipps++;
                        }
                        break;
                    }
                    case ConsoleKey.LeftArrow:
                    {
                        if (skipps > 0)
                        {
                            skipps--;
                        }
                        break;
                    }
                }
            }
        }
    }
}
