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

            // Виводимо каталоги і файли в таблицю 
            ShowFF showFoldersFiles = new ShowFF();
            showFoldersFiles.Show("G", "left");     // Вивід в лівому вікні
            showFoldersFiles.Show("D", "right");    // Вивід в правому вікні




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



            temp temp = new temp();
            //temp.MenuTemp();
            //temp.PaginationTemp();
            temp.MenuPlusPagination();

        }
    }
}
