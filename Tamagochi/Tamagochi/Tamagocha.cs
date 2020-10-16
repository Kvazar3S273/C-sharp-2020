using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//- Покормить
//- Погулять
//- Уложить спать
//- Полечить
//- Поиграть

namespace Tamagochi
{
    class Tamagocha
    {
        public Tamagocha()
        {

        }

        //public Hashtable(int key, Tamagocha );


        public delegate void Request();

        Request rq;

        public void Eat()
        {
            Console.Write("Кітті: ");
            Console.WriteLine("Погодуй мене!");
        }
        public void Walk()
        {
            Console.Write("Кітті: ");
            Console.WriteLine("Погуляй зі мною!");
        }
        public void Sleep()
        {
            Console.Write("Кітті: ");
            Console.WriteLine("Поклади мене спати!");
        }
        public void Treat()
        {
            Console.Write("Кітті: ");
            Console.WriteLine("Полікуй мене!");
        }
        public void Play()
        {
            Console.Write("Кітті: ");
            Console.WriteLine("Пограй зі мною!");
        }
        public void Form()
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|                                Клавіші:       |");
            Console.WriteLine("|       |\\           /|                         |");
            Console.WriteLine("|       | \\_________/ |        (1) Погодувати   |");
            Console.WriteLine("|      /               \\       (2) Погуляти     |");
            Console.WriteLine("|     |                 |      (3) Сон          |");
            Console.WriteLine("|     |   ()       ()   |      (4) Полікувати   |");
            Console.WriteLine("|     |       _/\\_      |      (5) Погратись    |");
            Console.WriteLine("|     |                 |      (0) Відмова      |");
            Console.WriteLine("|      \\_______________/                        |");
            Console.WriteLine("|                                 Життя: 3      |");
            Console.WriteLine("|_______________________________________________|");
        }
            
            
            
            
            
            
    }
}
