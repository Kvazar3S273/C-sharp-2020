using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    class Tamagocha
    {
        public Tamagocha()
        {

        }

        public delegate void Request();
               
        public string EEat()
        {
            return "Погодуй мене!";
        }
        
        public string WWalk()
        {
            return "Погуляй зі мною!";
        }
        
        public string SSleep()
        {
            return "Поклади мене спати!";
        }
        
        public string TTreat()
        {
            return "Полікуй мене!";
        }
        
        public string PPlay()
        {
            return "Пограй зі мною!";
        }
        public void Form()
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine("|                             |");
            Console.WriteLine("|                             |");
            Console.WriteLine("|       |\\           /|       |");
            Console.WriteLine("|       | \\_________/ |       |");
            Console.WriteLine("|      /               \\      |");
            Console.WriteLine("|     |                 |     |");
            Console.WriteLine("|     |   ()       ()   |     |");
            Console.WriteLine("|     |       _/\\_      |     |");
            Console.WriteLine("|     |                 |     |");
            Console.WriteLine("|      \\_______________/      |");
            Console.WriteLine("|                             |");
            Console.WriteLine("|_____________________________|");
        }
            
    }
}
