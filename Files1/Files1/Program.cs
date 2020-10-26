using System;
using System.IO;
using System.Text;

namespace Files1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            // Вводимо шлях до папки
            Console.WriteLine(@"Введіть шлях до папки (наприклад G:\STEP\TEST\)");
            string path = Console.ReadLine();   
            
            // Вводимо слово, яке будемо шукати
            Console.WriteLine("Введіть слово, яке потрібно знайти");
            string word = Console.ReadLine();
            
            // Вводимо слово, яким будемо заміняти знайдене слово
            Console.WriteLine("Введіть слово, на яке потрібно замінити знайдене слово");
            string newWord = Console.ReadLine();
            
            // Формуємо масив всіх знайдених у папці файлів
            string[] fileEntries = Directory.GetFiles(path);

            // Виводимо табличку (шапка)
            Console.WriteLine("----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| Назва файлу, у якому є таке слово | Кількість входжень |");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------");
            
            // Проходимо циклом по всіх файлах, щоб знайти файли, які містять шукане слово
            //for (int i = 0; i < fileEntries.Length; i++)
            //{
            //    FileStream fs = new FileStream(fileEntries[i], FileMode.Open, FileAccess.Read);
            //    byte[] bytes = new byte[fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    string str = Encoding.Default.GetString(bytes);
                
            //    // Якщо в файлі міститься шукане слово, виводимо назву файла і кількість входжень слова
            //    if (str.Contains(word))
            //        {
            //            // Підраховуємо кількість входжень    
            //            int count = (str.Length - str.Replace(word, "").Length) / word.Length;
            //            // Відділяємо від повного шляху тільки на    зву файла
            //            string fileName = Path.GetFileName(fileEntries[i]);
            //            Console.WriteLine("|   {0,-21}           |{1,15}     |",fileName, count);
            //        }
                
            //    // Закриваємо файловий потік
            //    fs.Dispose();
            //}
            //Console.WriteLine("---------------------------------------------------------");


            for (int i = 0; i < fileEntries.Length; i++)
            {
                FileStream fs = new FileStream(fileEntries[i], FileMode.Open, FileAccess.ReadWrite);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                string str = Encoding.Default.GetString(bytes);
                // Якщо в файлі міститься шукане слово, виводимо назву файла і кількість входжень слова
                if (str.Contains(word))
                {
                    // Підраховуємо кількість входжень    
                    int count = (str.Length - str.Replace(word, "").Length) / word.Length;
                    // Відділяємо від повного шляху тільки на    зву файла
                    string fileName = Path.GetFileName(fileEntries[i]);
                    Console.WriteLine("|   {0,-21}           |{1,15}     |", fileName, count);
                }
                    string newStr = str.Replace(word, newWord);
                    byte[] newBytes = Encoding.UTF8.GetBytes(newStr);
                //fs.Write(bytes, 0, bytes.Length);
                //string str = Encoding.Default.GetString(bytes);

                
                fs.Write(newBytes);
                // Закриваємо файловий потік
                fs.Dispose();

            }
            Console.WriteLine("---------------------------------------------------------");


        }
    }
}
