using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NortonCommander
{
    public class Drives
    {
        public void ShowDrive(string name)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            //for (int i = 0; i < drives.Length; i++)
            //{
            //    Console.WriteLine($"Назва диска: {drives[i].Name}");
            //    Console.WriteLine($"Тип: {drives[i].DriveType}");
            //    if (drives[i].IsReady)
            //    {
            //        Console.WriteLine($"Об\'єм диска: {drives[i].TotalSize / 1024 / 1024 / 1024} Gb");
            //        Console.WriteLine($"Доступно мiсця: {drives[i].TotalFreeSpace / 1024 / 1024 / 1024} Gb");
            //    }
            //    Console.WriteLine();
            //}
            int discNumber = 0;
            switch (name)
            {
                case "c":
                case "C":
                    discNumber = 0;
                    break;
                case "d":
                case "D":
                    discNumber = 1;
                    break;
                case "e":
                case "E":
                    discNumber = 2;
                    break;
                case "f":
                case "F":
                    discNumber = 3;
                    break;
                case "g":
                case "G":
                    discNumber = 4;
                    break;
                //case "h":
                //case "H":
                //    discNumber = 5;
                //    break;
                //case "i":
                //case "I":
                //    discNumber = 6;
                //    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }

            Console.WriteLine($"Назва диска: {drives[discNumber].Name}");
            Console.WriteLine($"Тип: {drives[discNumber].DriveType}");
            if (drives[discNumber].IsReady)
            {
                Console.WriteLine($"Об\'єм диска: {drives[discNumber].TotalSize / 1024 / 1024 / 1024} Gb");
                Console.WriteLine($"Доступно мiсця: {drives[discNumber].TotalFreeSpace / 1024 / 1024 / 1024} Gb");
            }
        }
       
    }
}
