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
            
            
            for (int i = 0; i < fileEntries.Length; i++)
            {
                string st = string.Empty;   // сюди будемо зчитувати весь вміст файла
                StreamReader read = File.OpenText(fileEntries[i]);  // відкриваємо файл для читання
                st = read.ReadToEnd();  // зчитуємо файл в рядок
                if(st.Contains(word))   // якщо файл містить шукане слово, то...
                {
                    int count = (st.Length - st.Replace(word, "").Length) / word.Length;    // ...рахуємо кількість входжень
                    string fileName = Path.GetFileName(fileEntries[i]);     // ...виділяємо назву файла із повного шляху
                    Console.WriteLine("|   {0,-21}           |{1,15}     |", fileName, count);  // ...виводимо знайдену інформацію
                }
                read.Dispose(); // закриваємо файл
                st = st.Replace(word, newWord); // у зчитаному рядку замінюємо всі знайдені слова на запропоноване слово
                StreamWriter write = new StreamWriter(fileEntries[i]);  // відкриваємо файл для запису нового вмісту
                write.Write(st);    // записуємо рядок у файл
                write.Dispose();    // закриваємо файл
            }
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
