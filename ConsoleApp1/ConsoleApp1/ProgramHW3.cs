//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class ProgramHW3
//    {
//        static void Main(string[] args)
//        {

//            Console.OutputEncoding = Encoding.Unicode;
//            Console.InputEncoding = Encoding.Unicode;

//            /*1  Користувач вводить рядок і символ.
//            У рядку знайти всі входження цього символа і перевести його у верхній регістр, 
//            а також видалити частину рядка, після останнього входження цього символу і до кінця.*/

//            //string str1;
//            //Console.WriteLine("Enter string");
//            //str1 = Console.ReadLine();          //enter string
//            //Console.WriteLine("Enter symbol");
//            //string symb;
//            //symb = Console.ReadLine();          //enter symbol
//            //string str2 = str1;                   //copying string
//            //str1 = str1.Replace(symb, symb.ToUpper());    //replace finded symbols to upper registr
//            //Console.WriteLine(str1);
//            //char smb = char.Parse(symb);      //variable for find our symbol
//            //int ind = 0;      
//            //for (int i = 0; i< str2.Length-1; i++)
//            //{
//            //    if (str2[i] == smb)
//            //    {
//            //        ind = i;                  //index of finded symbol
//            //    }
//            //}

//            //str2 = str2.Remove(ind+1);           //delete string from finded index to end of string
//            //str2 = str2.Replace(symb, symb.ToUpper());    //replace finded symbols to upper registr in str2
//            //Console.WriteLine(str2);


//            /*2   Дано два рядки.
//            Необхідно з першого рядка видалити всі символи, які зустрічаються в рядку 2.
//            Вивести одержаний рядок, а також статистику по обробці:
//            - кількість видалених символів усього
//            - кількість видалених входжень кожного символа
//            - кількість символів, яка залишилась в рядку.*/

//            //string str3;
//            //string str4;
//            //Console.WriteLine("Enter string 1: ");
//            //str3 = Console.ReadLine();
//            //Console.WriteLine("Enter string 2: ");
//            //str4 = Console.ReadLine();
//            //int qty_del = 0;    //quantity of full deleted symbols / кількість видалених символів усього
//            //Console.ForegroundColor = ConsoleColor.Red;
//            //Console.WriteLine();
//            //Console.WriteLine($"There are  {str3.Length}  symbols in first string");
//            //Console.ResetColor();
//            //Console.WriteLine();
//            //char[] s4 = str4.ToCharArray();   //remake string for find to char array
//            //for (int i = 0; i < str4.Length; i++)
//            //{
//            //    int del = 0;                  //quantity of deleted elements
//            //    for (int j = 0; j < str3.Length; j++)
//            //    {
//            //        if (str3.Contains(s4[i]))
//            //            {
//            //            int temp = str3.IndexOf(s4[i]);   //find index of element do delete
//            //            str3 = str3.Remove(temp, 1);      //delete finded element
//            //            qty_del++;                        //qty of all deleted symbols
//            //            del++;
//            //            }
//            //    }
//            //    if (del != 0)
//            //        Console.WriteLine($"Symbol \"{s4[i]}\" was deleted {del} raz");//out statistic for all deleted symbols
//            //}
//            //Console.WriteLine();
//            //Console.WriteLine("String after deleted symbols:");
//            //Console.ForegroundColor = ConsoleColor.Yellow;
//            //Console.WriteLine(str3);
//            //Console.WriteLine();
//            //Console.ForegroundColor = ConsoleColor.Green;
//            //Console.WriteLine($"Was deleted {qty_del}  symbols");
//            //Console.WriteLine($"There are was lasted {str3.Length}  symbols");
//            //Console.ResetColor();


//            /*3   Створити метод, що приймає введений користувачем рядок і виводить на екран статистику по цьому рядку. 
//            Статистика повинна включати:
//            +загальну кількість символів,
//            +кількість літер
//            +скільки літер у верхньому регістрі
//            +скільки літер у нижньому регістрі
//            +кількість цифр,
//            +кількість символів пунктуації
//            +кількість пробільних символів.*/

//            //string str5;
//            //Console.WriteLine("Enter string");
//            //str5 = Console.ReadLine();
//            //Console.WriteLine($"Quantity of all symbols is  {str5.Length}");
//            //int count_letter = 0;
//            //int count_upper = 0;
//            //int count_lower = 0;
//            //int count_digit = 0;
//            //int count_punct = 0;
//            //int count_space = 0;

//            //foreach (var item in str5)
//            //{
//            //    if (char.IsLetter(item))
//            //        count_letter++;
//            //    if (char.IsUpper(item))
//            //        count_upper++;
//            //    if (char.IsLower(item))
//            //        count_lower++;
//            //    if (char.IsDigit(item))
//            //        count_digit++;
//            //    if (char.IsPunctuation(item))
//            //        count_punct++;
//            //    if (char.IsWhiteSpace(item))
//            //        count_space++;
//            //}
//            //Console.WriteLine($"Quantity of letter is  {count_letter}");
//            //Console.WriteLine($"Quantity of upper letter is  {count_upper}");
//            //Console.WriteLine($"Quantity of lower letter is  {count_lower}");
//            //Console.WriteLine($"Quantity of digits is  {count_digit}");
//            //Console.WriteLine($"Quantity of punctuation is  {count_punct}");
//            //Console.WriteLine($"Quantity of space is  {count_space}");


//        }
//    }
//}
