using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NortonCommander
{
    class ShowFF
    {
        // Show Folders and Files

        public void Show1(string name, string side)
        {
            string discName = name;
            string dirName = discName + ":\\";
            Console.WriteLine();

            int position = 1;
            switch (side)
            {
                case "left":
                    position = 1;
                    break;
                case "right":
                    position = 41;
                    break;
                default:
                    position = 1;
                    break;
            }

            //string dirName = "C:\\Program Files";
            string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів

            int skipps = 0;
            int numberItemsOnPage = 18;

            var collection = dirs.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    //Console.Clear();
                    Console.CursorVisible = false;
                    collection = dirs.Skip(skipps * numberItemsOnPage).Take(numberItemsOnPage);
                    if (collection.Count() <= 0)
                    {
                        skipps--;
                        break;
                    }

                    //Console.WriteLine("------------------------------");
                    //foreach (var item in collection)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    //Console.WriteLine("------------------------------");

                    var outputDirs = collection.ToArray();
                    for (int i = 0; i < outputDirs.Length; i++)
                    {
                        Console.SetCursorPosition(position, 5 + i);
                        string path = outputDirs[i]; // Отримуємо повний шлях до підпапки
                        outputDirs[i] = outputDirs[i].Substring(3);     // Обрізаємо початок шляху до каталога
                        if (outputDirs[i].Length > 11)            // Якщо назва довга, обрізаємо її
                        {
                            outputDirs[i] = outputDirs[i].Substring(0, 11);
                            outputDirs[i] += "►";

                            Console.WriteLine("{0,-10}│►SUB-DIR◄│{1,8:dd/MM/yy}│{2,6:hh:mm}"
                                , outputDirs[i]
                                , new DirectoryInfo(path).CreationTime
                                , new DirectoryInfo(path).CreationTime);
                        }
                        else
                        {
                            Console.WriteLine("{0,-12}│►SUB-DIR◄│{1,8:dd/MM/yy}│{2,6:hh:mm}"
                                , outputDirs[i]
                                , new DirectoryInfo(path).CreationTime
                                , new DirectoryInfo(path).CreationTime);
                        }
                    }



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

        public void Show(string name, string side)
        {
            string discName = name;
            string dirName = discName + ":\\";
            Console.WriteLine();
            
            int position = 1;
            switch (side)
            {
                case "left":
                    position = 1;
                    break;
                case "right":
                    position = 41;
                    break;
                default:
                    position = 1;
                    break;
            }

            if (Directory.Exists(dirName))
            {
                Console.SetCursorPosition(position, 5);    // Задаємо позицію, з якої будемо виводити першу інформацію
                Console.BackgroundColor = ConsoleColor.DarkBlue;    // Колір фону

                
                string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів

                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.SetCursorPosition(position, 5 + i);
                    string path = dirs[i]; // Отримуємо повний шлях до підпапки
                    dirs[i] = dirs[i].Substring(3);     // Обрізаємо початок шляху до каталога
                    if (dirs[i].Length > 11)            // Якщо назва довга, обрізаємо її
                    {
                        dirs[i] = dirs[i].Substring(0, 11);
                        dirs[i] += "►";

                        Console.WriteLine("{0,-10}│►SUB-DIR◄│{1,8:dd/MM/yy}│{2,6:hh:mm}"
                            , dirs[i]
                            , new DirectoryInfo(path).CreationTime
                            , new DirectoryInfo(path).CreationTime);
                    }
                    else
                    {
                        Console.WriteLine("{0,-12}│►SUB-DIR◄│{1,8:dd/MM/yy}│{2,6:hh:mm}"
                            , dirs[i]
                            , new DirectoryInfo(path).CreationTime
                            , new DirectoryInfo(path).CreationTime);
                    }
                }
                
                string[] files = Directory.GetFiles(dirName);

                for (int i = 0; i < files.Length; i++)
                {
                    Console.SetCursorPosition(position, 5 + dirs.Length + i);
                    files[i] = files[i].Substring(3);

                    int indexOfLastPoint = files[i].LastIndexOf("."); // Індекс крапочки перед розширенням
                    string expansion = files[i].Substring(indexOfLastPoint + 1); // Отримуємо розширення
                    files[i] = files[i].Substring(0, files[i].Length - expansion.Length - 1); // Отримуємо назву файла

                    string path = dirName + files[i] + "." + expansion; // Отримуємо повний шлях до файла
                    FileInfo fi = new FileInfo(path);

                    // Виводимо назву файла, розширення, розмір в байтах, дату створення і час створення
                    if (files[i].Length > 6)   // Якщо назва довга - обрізаємо її
                    {
                        files[i] = files[i].Substring(0, 5);
                        files[i] += "►";
                        Console.Write("{0,-6}  {1,4}│{2,9}│{3,8:dd/MM/yy}│{4,6:hh:mm}"
                            , files[i]
                            , expansion
                            , fi.Length
                            , new FileInfo(dirName).CreationTime
                            , new FileInfo(dirName).CreationTime);
                    }
                    else
                    {
                        Console.Write("{0,-6}  {1,4}│{2,9}│{3,8:dd/MM/yy}│{4,6:hh:mm}"
                            , files[i]
                            , expansion
                            , fi.Length
                            , new FileInfo(dirName).CreationTime
                            , new FileInfo(dirName).CreationTime);
                    }
                }
            }
        }
    }
}
