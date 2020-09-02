//using System;

//namespace ConsoleApp1
//{
//    class ProgramHW1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter length of wall/floor, m");
//            double a;                                   //length of floor in meters /довжина підлоги в метрах
//            while (!Double.TryParse(Console.ReadLine(), out a) || a<=0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            a *= 1000;                 //convert a to mm
            
            
//            Console.WriteLine("Enter width of wall/floor, m");
//            double b;                                   //width of floor in meters  /ширина підлоги в метрах
//            while (!Double.TryParse(Console.ReadLine(), out b) || b<=0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            b *= 1000;                 //convert b to mm

//            Console.WriteLine("Enter length of brick, mm");
//            double l;                                   //size of brick in mm   /розмір плитки
//            while (!Double.TryParse(Console.ReadLine(), out l) || l<=0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            int ax;         //size of cutten piece by length    /ширина відрізаного шматка по довжині
//            int bx;         //size of cutten piece by width     /ширина відрізаного шматка по ширині
//            Console.ForegroundColor = ConsoleColor.Red;
//            if (a * b < l * l)
//            {
//                Console.WriteLine("The size of the floor cannot be smaller than the size of the tile!");
//                return;
//            }
//            else
//            {
//                Console.Write("Entire q-ty of bricks by length is: ");
//                int ka_entire = Convert.ToInt32(a / l);     //q-ty of entire bricks by length   /к-сть цілих плитчин в ряду по довжині
//                if (a % l != 0)
//                {
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(ka_entire + 1);
//                    ax = (int)((ka_entire - a / l) * l);        
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.Write("Width of cutten piece by length of floor in mm: ");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(Math.Abs(ax));
//                    Console.WriteLine();
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(ka_entire);
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.WriteLine("There are no cutten pieces by length\n");
//                }
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.Write("Entire q-ty of bricks by width is: ");
//                int kb_entire = Convert.ToInt32(b / l);      //q-ty of entire bricks by width    /к-сть цілих плитчин в ряду по ширині
//                if (b % l != 0)
//                {
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(kb_entire + 1);
//                    bx = (int)((kb_entire - b / l) * l);        
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.Write("Length of cutten piece by width of floor in mm: ");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(Math.Abs(bx));
//                    Console.WriteLine();
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine(kb_entire);
//                    Console.ForegroundColor = ConsoleColor.Yellow;
//                    Console.WriteLine("There are no cutten pieces by width\n");
//                }
//                if (a % l != 0 && b % l != 0)
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.Write("Size of last cutten piece (in corner) is: ");
//                    ax = (int)((ka_entire - a / l) * l);
//                    bx = (int)((kb_entire - b / l) * l);
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine($"length = { Math.Abs(ax) }, width = { Math.Abs(bx) } mm");
//                }

//            }
//            Console.ResetColor();
//            Console.WriteLine();
//            double consumption;     //consumption of glue
//            double thick;           //thickness of glue layer
//            double bag_weight;      //weight of glue bag
//            Console.WriteLine("Enter glue consumption (kg/sq.m. with layer thickness = 1 mm)");
//            while (!Double.TryParse(Console.ReadLine(), out consumption) || consumption <= 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            Console.WriteLine("Enter thickness of glue layer (mm)");
//            while (!Double.TryParse(Console.ReadLine(), out thick) || thick <= 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            Console.WriteLine("Enter weight of glue bag (kg)");
//            while (!Double.TryParse(Console.ReadLine(), out bag_weight) || bag_weight <= 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("You entered incorrect value! Try again...");
//                Console.ResetColor();
//            }
//            double full_consumpt = a * b * consumption * thick / 1000000;
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"Full consumption of glue {full_consumpt} kg");
//            int qty_bag = (int)(full_consumpt / bag_weight);
//            int need_bag;
//            if (full_consumpt % bag_weight == 0)
//            {
//                need_bag = qty_bag;
//            }
//            else
//            {
//                need_bag = qty_bag + 1;
//            }
//            Console.WriteLine($"Quantity of bag: {need_bag}");
//            Console.WriteLine($"Will remain {need_bag * bag_weight - full_consumpt} kg");
//            Console.ResetColor();

//        }
//    }
//}