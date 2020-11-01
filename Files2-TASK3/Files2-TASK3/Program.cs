using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Files2_TASK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Створюємо рахунок перший раз і серіалізуємо його в файл "j3.json"
            // -----------------------------------------------------------------
            //BillToPay btp = new BillToPay("400", "7", "140", "4");
            //btp.ToSerializeWhenFalse();
            //string jsonString;
            //jsonString = JsonSerializer.Serialize(btp);//, options);
            //File.WriteAllText(@"g:\step\jjj.json", jsonString);
            // ------------------------------------------------------------------

            //// Десеріалізація--------------------------------------------------
            //string jsonString = File.ReadAllText(@"g:\step\jjj.json");
            //BillToPay btp = JsonSerializer.Deserialize<BillToPay>(jsonString);
            //Console.WriteLine(btp);
            ////-----------------------------------------------------------------

            BillToPay btp = new BillToPay("400", "7", "140", "4");

            BillToPay.FlagSerialize = true;
            using (FileStream fs = new FileStream(@"g:\step\my.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                XmlSerializer format = new XmlSerializer(typeof(BillToPay));
                format.Serialize(fs, btp);
            }


            Console.WriteLine("Якщо ви хочете серіалізувати весь список-натисніть +");
            Console.WriteLine("Якщо ви хочете серіалізувати не весь список-натисніть *");
            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.KeyChar == '+')
            {

                //Серіалізуємо все.

                if (BillToPay.FlagSerialize)
                {

                    string path1 = @"g:\step\my.xml";
                    var serializer = new XmlSerializer(typeof(BillToPay));

                    using (var stream = File.OpenWrite(path1))
                    {
                        serializer.Serialize(stream, btp);
                    }
                }
            }
            if (keys.KeyChar == '*')
            {
                BillToPay.FlagSerialize = false;

                // Серіалізуємо тільки певні поля.


                if (!BillToPay.FlagSerialize)
                {
                    using (XmlWriter writer = XmlWriter.Create(@"g:\step\my.xml"))
                    {


                        writer.WriteStartDocument();

                            writer.WriteStartElement("Account");
                            writer.WriteElementString("TotalSum", btp.SumPaymentNoFine);
                            writer.WriteElementString("PenaltySum", btp.SumFine);
                            writer.WriteElementString("FinishSum", btp.FullPaymentSum);


                            writer.WriteEndElement();

                        writer.WriteEndDocument();
                    }
                }
            }






        }
    }
}
