using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProgramHW3
    {
        static void Main(string[] args)
        {
            /*1  Користувач вводить рядок і символ.
            У рядку знайти всі входження цього символа і перевести його у верхній регістр, 
            а також видалити частину рядка, після останнього входження цього символу і до кінця.*/

            string str1;
            Console.WriteLine("Enter string");
            str1 = Console.ReadLine();          //ввели рядок
            Console.WriteLine("Enter symbol");
            string symb;
            symb = Console.ReadLine();          //ввели символ
            string str2 = str1;
            str1 = str1.Replace(symb, symb.ToUpper());
            Console.WriteLine(str1);
            char smb = char.Parse(symb);
            int ind = 0;
            for (int i = 0; i< str2.Length-1; i++)
            {
                if (str2[i] == smb)
                {
                    ind = i;
                }
            }

            str2 = str2.Remove(ind+1);
            str2 = str2.Replace(symb, symb.ToUpper());
            Console.WriteLine(str2);


            /*2   Дано два рядки.
            Необхідно з першого рядка видалити всі символи, які зустрічаються в рядку 2.
            Вивести одержаний рядок, а також статистику по обробці:
            - кількість видалених символів усього
            - кількість видалених входжень кожного символа
            - кількість символів, яка залишилась в рядку.*/



        }
    }
}
