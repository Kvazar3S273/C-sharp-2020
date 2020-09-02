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
            

            str1 = str1.Replace(symb, symb.ToUpper());

            Console.WriteLine(str1);
        }
    }
}
