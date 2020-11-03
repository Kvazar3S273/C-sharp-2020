using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Files2_TASK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //// Створюємо рахунок перший раз і серіалізуємо його в файл "jjj.json"
            //// -----------------------------------------------------------------
            BillToPay btp = new BillToPay("400", "7", "140", "4");
            string jsonString;

            // Прапорець керування форматом серіалізації (false - серіалізує всі поля, true - всі, крім обраховуваних)
            Console.WriteLine("Для серіалізації всіх полів натисніть (1)");
            Console.WriteLine("Для серіалізації тільки полів, які не обраховуються натисніть (0)");
            string check = Console.ReadLine();
            bool flag = true;
            if (check == "1")
            {
                flag = false;
            }
            else if (check == "0")
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("Неправильний вибір");
                return;
            }
            var options = new JsonSerializerOptions
            {
                IgnoreReadOnlyProperties = flag,
                WriteIndented = true
            };
            jsonString = JsonSerializer.Serialize(btp, options);
            File.WriteAllText(@"D:\ШАГ\0 Repository\C-sharp-2020\Files2-TASK3\Files2-TASK3\jjj.json", jsonString);
            
            //// ------------------------------------------------------------------


            //// Десеріалізація--------------------------------------------------
            //string jsonString = File.ReadAllText(@"D:\ШАГ\0 Repository\C-sharp-2020\Files2-TASK3\Files2-TASK3\jjj.json");
            ////Console.WriteLine(jsonString);
            //BillToPay btp = new BillToPay();
            //btp = JsonSerializer.Deserialize<BillToPay>(jsonString);
            //Console.WriteLine(btp);

            ////-----------------------------------------------------------------
        }
    }
}
