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
                                if (counter < 9) { counter++; } 
                                else { counter = 1; }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.UpArrow:
                            {
                                if (counter > 1) { counter--; }
                                else { counter = 9; }
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
        public void MenuPlusPagination()
        {
            while (true)
            {
                Console.Clear();
                string dirName = "C:\\Program Files";
                string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів
                int skipps = 0;
                int numberItemsOnPage = 18;
                //var collection = dirs.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
                var outputDirs1 = dirs.Skip(0).Take(18);
                string[] dirs1 = outputDirs1.ToArray();
                var outputDirs2 = dirs.Skip(17).Take(18);
                var outputDirs3 = dirs.Skip(35).Take(18);
                var outputDirs4 = dirs.Skip(53).Take(18);
                var outputDirs5 = dirs.Skip(71).Take(18);



                //Console.WriteLine("------------------------------");
                //foreach (var item in collection)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine("------------------------------");

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
                        //Console.WriteLine(dirs[i - 1]);
                        Console.WriteLine(dirs1[i - 1]);
                        Console.ResetColor();
                    }

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    key = keyInfo.Key;

                    switch (key)    //обхід меню стрілочками
                    {
                        case (ConsoleKey)ConsoleKey.DownArrow:  // аналіз натискання кнопки "вниз"
                            {
                                if (counter < 9)    // якщо лічильник менше 9,
                                { 
                                    counter++;      // то збільшуємо його
                                }
                                else 
                                { 
                                    counter = 1;    // якщо стає більше, то присвоюємо йому 1, перекидаємо наверх
                                }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.UpArrow:    // аналіз натискання кнопки "вгору"
                            {
                                if (counter > 1)    // якщо лічильник більше 1, 
                                { 
                                    counter--;      // то зменшуємо його
                                }
                                else 
                                { 
                                    counter = 9;    // якщо стає менше 1, то перекидаємо його на низ
                                }
                                break;
                            }
                            // добавити в перевірку діапазону лічильника
                            // якщо стає більше 9, то включати пагінацію і перевірити, чи там ще щось є
                            // якщо нема, то не переходити далі
                    }
                } while (key != ConsoleKey.Enter);
                Console.WriteLine("Ти відкрив папку {0}", dirs[counter - 1]);
                Console.ReadKey();
            }
        }
    }
}
