using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProgramHW4
    {
        static void Main(string[] args)
        {
            /*1.Сжать массив, удалив из него все 0 и, заполнить 
            освободившиеся справа элементы значениями –1*/

            int[] arr1 = { 0, 77, 12, 15, 0, 0, 0, 8, 10, 0 };
            int[] arr2 = new int[arr1.Length];
            int num = 0;

            Console.WriteLine("Array BEFORE : \n");
            for (int i = 0; i < arr1.Length; i++)
            {
                //Console.Write($"[{i}] = {arr1[i]} ");
                Console.Write($"{arr1[i]}\t");
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != 0)
                {
                    arr2[num] = arr1[i];
                    num++;
                }
            }

            for (int i = num; i < arr1.Length; i++)
            {
                arr2[i] = -1;
            }

            Console.WriteLine("\n\nArray AFTER : \n");
            for (int i = 0; i < arr2.Length; i++)
            {
                //Console.Write($"[{i}] = {arr2[i]}  ");
                Console.Write($"{arr2[i]}\t");
            }

            /*2.Преобразовать массив так, чтобы сначала шли все
            отрицательные элементы, а потом положительные (0 считать положительным)*/
            int[] arr3 = { 0, -77, 12, -15, 10, 30, -1, 8, -10, 23 };
            int[] arr4 = new int[arr1.Length];


        }
    }
}
