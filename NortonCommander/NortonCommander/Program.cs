using System;
using System.IO;

namespace NortonCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            Drives disc = new Drives();
            Console.WriteLine("Choice disc: A-B-C-D-E-F-G-H-I");
            string discName = Console.ReadLine();
            disc.ShowDrive(discName);

            string dirName = discName+":\\";
            Console.WriteLine();
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Пiдкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файли:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
