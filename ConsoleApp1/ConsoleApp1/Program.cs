using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter length of wall/floor, m");
            string _a = Console.ReadLine();                      //length of floor in meters /довжина підлоги в метрах
            Console.WriteLine("Enter width of wall/floor, m");
            string _b = Console.ReadLine();                     //width of floor in meters  /ширина підлоги в метрах
            Console.WriteLine("Enter length of brick, mm");
            string _l = Console.ReadLine();                     //size of brick in mm   /розмір плитки
            double a = Double.Parse(_a) * 1000;                 //convert a to mm
            double b = Double.Parse(_b) * 1000;                 //convert b to mm
            double l = Double.Parse(_l);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Entire q-ty of bricks by length is: ");
            int ka_entire = Convert.ToInt32(a / l);             //q-ty of entire bricks by length   /к-сть цілих плитчин в ряду по довжині
            if (a % l != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ka_entire + 1);
                int ax = (int)((ka_entire - a / l) * l);        //size of cutten piece by length    /ширина відрізаного шматка по довжині
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Width of cutten piece by length of floor in mm: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Math.Abs(ax));
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ka_entire);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("There are no cutten pieces by length\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Entire q-ty of bricks by width is: ");
            int kb_entire = Convert.ToInt32(b / l);             //q-ty of entire bricks by width    /к-сть цілих плитчин в ряду по ширині
            if (b % l != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(kb_entire + 1);
                int bx = (int)((kb_entire - b / l) * l);        //size of cutten piece by width     /ширина відрізаного шматка по ширині
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Length of cutten piece by width of floor in mm: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Math.Abs(bx));
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(kb_entire);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("There are no cutten pieces by width\n");
            }
            if (a % l != 0 && b % l != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Size of last cutten piece (in corner) is: ");
                int ax = (int)((ka_entire - a / l) * l);
                int bx = (int)((kb_entire - b / l) * l);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"length= { Math.Abs(ax) }, width= { Math.Abs(bx) }");
            }
            Console.ResetColor();
        }
    }
}