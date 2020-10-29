using System;
using System.IO;
using System.Text;

namespace Files2_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Вводимо шлях до папки
            Console.WriteLine(@"Введіть шлях до папки (наприклад G:\STEP\)");
            string path = Console.ReadLine();

            // Перевіримо чи користувач ввів символ \ в кінці шляху до файла, якщо ні, то додамо його самі
            if(!path.EndsWith("\\"))
            {
                path+="\\";
            }

            // Вводимо назву файла, якого будемо шукати
            Console.WriteLine("Введіть назву файла, який містить зображення (наприклад \"picture.jpg\")");
            string fileName = Console.ReadLine();

            // Перевіримо чи користувач правильно ввів розширення файла
            bool checkExp = false;
            while (!checkExp)
            {
                checkExp = true;
                try
                {
                    if(!fileName.EndsWith(".jpg"))
                    {
                        throw new FileNameEx();
                    }
                }
                catch (FileNameEx ex)
                {
                    Console.WriteLine(ex.Message);
                    checkExp = false;
                    //Console.ReadKey();
                    Console.WriteLine("Повторно введіть ім\'я файла");
                    fileName = Console.ReadLine();
                }
            }
            
            // Створюємо повний шлях до файлу з назвою самого файлу
            string fullName = path + fileName;

            // Перевіряємо чи є такий файл в тій папці
            if(!File.Exists(fullName))
            {
                Console.WriteLine("Даного файла в папці немає!");
                return;
            }


            // Вводимо кількість копій
            Console.WriteLine("Введіть кількість копій");
            int count = int.Parse(Console.ReadLine());

            // Створюємо байтовий масив
            byte[] bytes;

            using (FileStream fs=new FileStream(fullName,FileMode.Open,FileAccess.Read))
            {
                using(BinaryReader br=new BinaryReader(fs,Encoding.Default))
                {
                    // Копіюємо вміст файла в байтовий масив
                    bytes = new byte[fs.Length];
                    br.Read(bytes, 0, bytes.Length);
                }
            }

            // Виділяємо назву файла без розширення
            string newTempFileName = fileName.Substring(0, fileName.Length - 4);
            
            // Проходимо циклом стільки разів, скільки потрібно скопіювати наш файл
            for (int i = 1; i <= count; i++)
            {
            using (FileStream fs = new FileStream(path + newTempFileName + i + ".jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
                    {
                        // Копіюємо інформацію в новий файл з байтового масиву
                        bw.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }
    }
    class FileNameEx : ApplicationException
    {
        public override string Message => "Неправильно введене розширення в імені файла!";
    }
}
