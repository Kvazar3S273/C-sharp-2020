using System;

namespace HouseBuilding
{
    public interface IWorker
    {
        string Name { get; set; }   //ім"я працівника

        IPart DoWork(House house);  //працівник працює над будинком, і повертає ту частину, яку він завершив
    }

    public class Worker : IWorker
    {
        public string Name { get; set; }    //ім"я будівельника

        public IPart DoWork(House house)
        {
            //проходимо по частинам будинку, знаходимо першу незавершену і завершуємо її
            foreach (var part in house.Parts)
            {
                if (part != null && !part.IsReady)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Збудовано: {part.Name} будівельником {Name}");
                    Console.ResetColor();
                    part.IsReady = true;    //частина готова
                    return part;    //повертаємо збудовану частину
                }
            }

            //якщо будинок завершено - повертаємо null - роботи більше немає
            Console.WriteLine($"Немає роботи для {Name}");
            return null;
        }
    }

    public class TeamLeader : IWorker
    {
        public string Name { get; set; }    //ім"я бригадира

        public IPart DoWork(House house)
        {
            if (house.IsReady)  //якщо будинок уже завершено - звіт не робиться, повертаємо null
            {
                Console.WriteLine("Будинок готовий");
                return null;
            }

            bool hasUnfinishedParts = false;    //є незавершені частини

            Console.WriteLine("\n====================================================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Звіт по будівництву для будинку {house.Name} від бригадира {Name}");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------------------");

            foreach (var part in house.Parts)
            {
                if (part != null)
                {
                    Console.WriteLine("Статус готовності частини: {0} - {1}", part.Name, part.IsReady ? "Готова" : "НЕ ГОТОВА");

                    if (!part.IsReady)
                        hasUnfinishedParts = true;
                }
            }

            //якщо при формуванні звіту не виявлено жодної незавершеної частини - фіксуємо завершення будівництва
            if (!hasUnfinishedParts)
            {
                house.IsReady = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t!!!БУДИНОК ГОТОВИЙ!!!");
                Console.ResetColor();
            }

            Console.WriteLine("====================================================================\n");
            
            return house;   //повертаємо будинок
        }
    }

    public class Team
    {
        public string Name { get; set; }

        public IWorker[] Workers { get; set; }  //масив працівників

        public bool Validate()  //перевірка наявності в команді будівельників і бригадира
        {
            bool hasWorker = false;
            bool hasLeader = false;
            foreach (var worker in Workers)
            {
                //перевіряємо команду, щоб у ній був хоча-б один працівник, інакше будинок не буде будуватися
                if (worker is Worker)
                    hasWorker = true;
                //перевіряємо команду, щоб у ній був хоча-б один бригадир, інакше не буде встановлено факт завершення будівництва
                if (worker is TeamLeader)
                    hasLeader = true;
            }

            if (!hasWorker)
            {
                Console.WriteLine("Не можливо побудувати будинок без будівельників");
                return false;
            }

            if (!hasLeader)
            {
                Console.WriteLine("Не можливо встановити факт завершення будівництва");
                return false;
            }

            return true;
        }

        public void BuildHouse(House house)
        {
            //перевірки перед будівництвом будинку
            if (!house.Validate())
                return;

            if (!Validate())
                return;

            while (!house.IsReady)  //будівництво будинку продовждується, поки він не завершений
            {
                bool someWorkWereDone = false;

                foreach (var worker in Workers)
                {
                    var donePart = worker.DoWork(house);
                    
                    //якщо метод повернув непустий результат - якась робота виконувалася (будувалося, або робився звіт)
                    //то фіксуємо, що щось робилося за цей день
                    if (donePart != null)
                        someWorkWereDone = true;
                }

                //якщо усі працівники відпрацювали день і нічого не зробили - значить усі роботи завершені, 
                //і виходимо із процесу будівництва
                if (!someWorkWereDone)
                {
                    Console.WriteLine("Будівництво зупинене, тому що відсутня робота для бригади!!!");
                    break;
                }
            }
        }
    }
}
