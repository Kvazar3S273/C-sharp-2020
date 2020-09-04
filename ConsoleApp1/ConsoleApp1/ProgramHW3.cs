using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProgramHW3
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /*1  Користувач вводить рядок і символ.
            У рядку знайти всі входження цього символа і перевести його у верхній регістр, 
            а також видалити частину рядка, після останнього входження цього символу і до кінця.*/

            //string str1;
            //Console.WriteLine("Enter string");
            //str1 = Console.ReadLine();          //ввели рядок
            //Console.WriteLine("Enter symbol");
            //string symb;
            //symb = Console.ReadLine();          //ввели символ
            //string str2 = str1;
            //str1 = str1.Replace(symb, symb.ToUpper());
            //Console.WriteLine(str1);
            //char smb = char.Parse(symb);
            //int ind = 0;
            //for (int i = 0; i< str2.Length-1; i++)
            //{
            //    if (str2[i] == smb)
            //    {
            //        ind = i;
            //    }
            //}

            //str2 = str2.Remove(ind+1);
            //str2 = str2.Replace(symb, symb.ToUpper());
            //Console.WriteLine(str2);


            /*2   Дано два рядки.
            Необхідно з першого рядка видалити всі символи, які зустрічаються в рядку 2.
            Вивести одержаний рядок, а також статистику по обробці:
            - кількість видалених символів усього
            - кількість видалених входжень кожного символа
            - кількість символів, яка залишилась в рядку.*/

            string str3;
            string str4;
            Console.WriteLine("Enter string 1: ");
            str3 = Console.ReadLine();
            Console.WriteLine("Enter string 2: ");
            str4 = Console.ReadLine();
            int qty_del = 0;    //quantity of full deleted symbols / кількість видалених символів усього
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"There are  {str3.Length}  symbols in first string");
            Console.ResetColor();
            Console.WriteLine();
            char[] s4 = str4.ToCharArray();
            for (int i = 0; i < str4.Length; i++)
            {
                int del = 0;
                for (int j = 0; j < str3.Length; j++)
                {
                    if (str3.Contains(s4[i]))
                        {
                        int temp = str3.IndexOf(s4[i]);
                        str3 = str3.Remove(temp, 1);
                        qty_del++;
                        del++;
                        }
                }
                if (del != 0)
                    Console.WriteLine($"Symbol \"{s4[i]}\" was deleted {del} raz");
            }
            Console.WriteLine();
            Console.WriteLine("String after deleted symbols:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str3);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Was deleted {qty_del}  symbols");
            Console.WriteLine($"There are was lasted {str3.Length}  symbols");
            Console.ResetColor();


        }
    }
}
