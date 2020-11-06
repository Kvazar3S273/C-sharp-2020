using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

// Консоль 150х60
// 80x25
namespace NortonCommander
{
    class Program
    {
        static void Main(string[] args)
        {

            // Вивід заголовка
            Draw title = new Draw();
            title.Title();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Вивід лівого вікна
            Draw tableLeft = new Draw();
            tableLeft.DrawOnceTable(0, 3);
            // Вивід правого вікна
            Draw tableRight = new Draw();
            tableRight.DrawOnceTable(40, 3);
            
            Draw discChoice = new Draw();
            
            // Вибір диска в лівому вікні
            //discChoice.DrawDiscChoise(1, 7);

            // Вибір диска в правому вікні
            //discChoice.DrawDiscChoise(41, 7);

            // Виводимо назву диска в лівому вікні 
            Console.SetCursorPosition(19, 3);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("D:\\");
            Console.ResetColor();

            // Виводимо назву диска в правому вікні 
            Console.SetCursorPosition(59, 3);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("D:\\");
            Console.ResetColor();

            // ► Alt+16

            string discName = "G";
            string dirName = discName + ":\\";
            Console.WriteLine();

            if (Directory.Exists(dirName))
            {
                Console.SetCursorPosition(1, 5);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                string[] dirs = Directory.GetDirectories(dirName);
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.SetCursorPosition(1, 5 + i);
                    dirs[i] = dirs[i].Substring(3);
                    if (dirs[i].Length>5)
                    {
                        dirs[i].TrimEnd();
                        dirs[i] += "►";
                    Console.WriteLine(dirs[i]);
                    }
                    else
                        Console.WriteLine(dirs[i]);

                }
                string[] files = Directory.GetFiles(dirName);
                //string expansionFiles = @"^.+\.([a-z0-9_-]{2,4})";
                for (int i = 0; i < files.Length; i++)
                {
                    Console.SetCursorPosition(1, 5 + dirs.Length + i);
                    files[i] = files[i].Substring(3);
                    int indexOfLastPoint = files[i].LastIndexOf("."); // Індекс крапочки перед розширенням
                    string expansion = files[i].Substring(indexOfLastPoint+1); // Отримуємо розширення
                    files[i] = files[i].Substring(0, files[i].Length - expansion.Length-1);
                    Console.Write("{0,-6}  {1,4}",files[i],expansion);
                }
            }

            // Вивід інформації про диск
            //Drives disc = new Drives();
            //Console.WriteLine("Choice disc: A-B-C-D-E-F-G-H-I");
            //string discName = Console.ReadLine();
            //disc.ShowDrive(discName);

            // Підвал
            Console.ResetColor();
            Draw footer = new Draw();
            footer.DrawFooter();
            Console.WriteLine();
        }
    }
}
