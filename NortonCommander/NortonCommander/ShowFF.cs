using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NortonCommander
{
    class ShowFF
    {
        // Show Folders and Files

        public void Show(string name)
        {
            string discName = name;
            string dirName = discName + ":\\";
            Console.WriteLine();

            if (Directory.Exists(dirName))
            {
                Console.SetCursorPosition(1, 5);    // Задаємо позицію, з якої будемо виводити першу інформацію
                Console.BackgroundColor = ConsoleColor.DarkBlue;    // Колір фону
                string[] dirs = Directory.GetDirectories(dirName);  // Отримуємо масив каталогів
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.SetCursorPosition(1, 5 + i);
                    dirs[i] = dirs[i].Substring(3);     // Обрізаємо початок шляху до каталога
                    if (dirs[i].Length > 11)            // Якщо назва довга, обрізаємо її
                    {
                        dirs[i] = dirs[i].Substring(0, 11);
                        dirs[i] += "►";
                        Console.WriteLine(dirs[i]);
                    }
                    else
                    {
                        Console.WriteLine(dirs[i]);
                    }
                }
                string[] files = Directory.GetFiles(dirName);

                for (int i = 0; i < files.Length; i++)
                {
                    Console.SetCursorPosition(1, 5 + dirs.Length + i);
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
