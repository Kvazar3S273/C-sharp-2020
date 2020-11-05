using System;
using System.IO;
using System.Runtime.InteropServices;
            
// Консоль 150х60
// 80x25
namespace NortonCommander
{
    class Program
    {
        static void Main(string[] args)
        {


            Draw title = new Draw();
            title.Title();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Draw tableLeft = new Draw();
            Draw tableRight = new Draw();

            
            tableLeft.DrawOnceTable(0, 3);
            tableRight.DrawOnceTable(40, 3);
            
            Draw discChoice = new Draw();
            discChoice.DrawDiscChoise(1, 7);

            Console.ResetColor();
            Draw footer = new Draw();
            footer.DrawFooter();

            // Вивід інформації про диск
            //Drives disc = new Drives();
            //Console.WriteLine("Choice disc: A-B-C-D-E-F-G-H-I");
            //string discName = Console.ReadLine();
            //disc.ShowDrive(discName);


            //string dirName = discName+":\\";
            //Console.WriteLine();
            //if (Directory.Exists(dirName))
            //{
            //    Console.WriteLine("Пiдкаталоги:");
            //    string[] dirs = Directory.GetDirectories(dirName);
            //    foreach (string s in dirs)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Файли:");
            //    string[] files = Directory.GetFiles(dirName);
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            Console.WriteLine();
        }
    }
}
