using System;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Dictionary dictionary = new Dictionary();
            dictionary.Add("Україна", "Ukraine");
            dictionary.Add("Польща", "Poland");
            dictionary.Add("Словаччина", "Slovakia");
            dictionary.Add("Румунія", "Romania");
            dictionary.Add("Угорщина", "Hungary");
            dictionary.Add("Німечччина", "Germany");
            dictionary.Add("Франція", "France");
            dictionary.Add("Нідерланди", "Holland");
            dictionary.Add("Бельгія", "Belgium");
            dictionary.Add("Білорусь", "Bieloruss");
            dictionary.Add("Туреччина", "Turkey");
            dictionary.Add("Канада", "Canada");
            dictionary.Add("Мексика", "Mexico");
            dictionary.Add("США", "USA");

            while (true)                        
            {
                Console.Clear();
                int counter = 1;
                ConsoleKey key = ConsoleKey.Escape;
                do
                {
                    Console.Clear();
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\n\n\n\n\t* Українсько-англійський словник");
                    Console.ResetColor();
                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Англо-український словник");
                    Console.ResetColor();
                    
                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine("\t* Вихід");
                    Console.ResetColor();

                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    key = keyInfo.Key;

                    switch (key)    //обхід меню стрілочками
                    {
                        case (ConsoleKey)ConsoleKey.DownArrow:
                            {
                                if (counter < 3) { counter++; }
                                else { counter = 1; }
                                break;
                            }
                        case (ConsoleKey)ConsoleKey.UpArrow:
                            {
                                if (counter > 1) { counter--; }
                                else { counter = 3; }
                                break;
                            }
                    }
                } while (key != ConsoleKey.Enter);
                Console.Clear();
                switch (counter)
                {
                    case 1:
                        {
                            Console.WriteLine("Зробіть вибір:");
                            Console.WriteLine("(1) - Переглянути всі слова");
                            Console.WriteLine("(2) - Здійснити переклад з української на англійську");
                            int tempKey = int.Parse(Console.ReadLine());
                            switch(tempKey)
                            {
                                case 1:
                                    {
                                        dictionary.ShowAllWordsUE();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Введіть назву країни УКР мовою:");
                                        string countryU = Console.ReadLine();
                                        dictionary.TranslateUE(countryU);
                                        break;
                                    }
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Зробіть вибір:");
                            Console.WriteLine("(1) - Переглянути всі слова");
                            Console.WriteLine("(2) - Здійснити переклад з англійської на українську");
                            int tempKey = int.Parse(Console.ReadLine());
                            switch (tempKey)
                            {
                                case 1:
                                    {
                                        dictionary.ShowAllWordsEU();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Введіть назву країни АНГЛ мовою:");
                                        string countryE = Console.ReadLine();
                                        dictionary.TranslateEU(countryE);
                                        break;
                                    }
                            }

                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            return;
                            break;
                        }
                }
            }
        }
    }
}
