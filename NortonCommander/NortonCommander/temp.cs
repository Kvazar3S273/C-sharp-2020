using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NortonCommander
{
    class temp
    {
        public void PaginationTemp()
        {
            string dirName = "C:\\Program Files";
            string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів

            int skipps = 0;
            int numberItemsOnPage = 6;

            var collection = dirs.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    collection = dirs.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
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

                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                } while (keyInfo.Key != ConsoleKey.UpArrow && keyInfo.Key != ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.Escape);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            if (skipps < dirs.Count() / 5)
                            {
                                skipps++;
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
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

        public void MenuTemp()
        {
            string dirName = "C:\\Program Files";
            string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів


            while (true)
            {
                Console.Clear();
                int counter = 1;
                ConsoleKey key = ConsoleKey.Escape;
                do
                {
                    Console.Clear();
                    for (int i = 1; i < 10; i++)
                    {
                        if (counter == i)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(dirs[i-1]);
                        Console.ResetColor();
                    }
                    
                    

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    key = keyInfo.Key;

                    switch (key)    //обхід меню стрілочками
                    {
                        case (ConsoleKey)ConsoleKey.DownArrow:
                            {
                                if (counter < 9) { counter++; } // тут теж 3
                                else { counter = 1; }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.UpArrow:
                            {
                                if (counter > 1) { counter--; }
                                else { counter = 9; }       // і тут 3
                                break;
                            }
                    }
                } while (key != ConsoleKey.Enter);
                Console.Clear();


                // Прописати що буде при натисканні кнопки ЕНТЕР при знаходженні на цій позиції

                Console.WriteLine("Ти відкрив папку {0}", dirs[counter-1]);
                Console.ReadKey();

                
            }
        }
    }
}
