using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseBuilding
{
    public interface IWorker
    {
        // кожен працівник має імя
        string Name { get; set; }

        // працівник працює над будинком, і повертає ту частину, яку він завершив
        IPart DoWork(House house);
    }

    public class Worker : IWorker
    {
        public string Name { get; set; }

        public IPart DoWork(House house)
        {
            // для звичайного працівника - пробігаємося по чавстинам будинку, знаходимо першу незавершену, завершуємо її, і виходимо з методу
            foreach (var part in house.Parts)
            {
                if (part != null && !part.IsReady)
                {
                    Console.WriteLine("Building part: {0} by {1}", part.Name, Name);
                    part.IsReady = true;
                    // повертаємо збудовану частину як результат методу, можливо знадобиться
                    return part;
                }
            }

            // якщо будинок завершено - повертаємо НАЛЛ - тобто нам нічого не дісталося по роботі
            Console.WriteLine("!!!!! No work for {0}", Name);
            return null;
        }
    }

    public class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public IPart DoWork(House house)
        {
            // якщо будинок уже завершено - звіт не робиться, повертаємо НАЛЛ
            if (house.IsReady)
            {
                Console.WriteLine("House is ready - No need for report for house {0} by {1} - house", house.Name, Name);
                return null;
            }

            bool hasUnfinishedParts = false;

            Console.WriteLine("***********************************************************");
            Console.WriteLine("Building report for house {0} by {1}", house.Name, Name);
            foreach (var part in house.Parts)
            {
                if (part != null)
                {
                    Console.WriteLine("Status of part: {0} is {1}", part.Name, part.IsReady ? "READY" : "notReady");

                    if (!part.IsReady)
                        hasUnfinishedParts = true;
                }
            }

            // якщо при формуванні звіту не виявлено жодної незавершеної частини - фіксуємо завершення будівництва
            if (!hasUnfinishedParts)
            {
                house.IsReady = true;
                Console.WriteLine("House is ready");
            }

            Console.WriteLine("***********************************************************");

            // завжди повертаємо будинок, так як ми над ним працювали формуючи звіт
            return house;
        }
    }

    public class Team
    {
        public string Name { get; set; }

        public IWorker[] Workers { get; set; }

        public bool Validate()
        {
            bool hasWorker = false;
            bool hasLeader = false;
            // перевіряємо команду, щоб у ній був хоча-б один працівник, інакше будинок не буде будуватися
            // перевіряємо команду, щоб у ній був хоча-б один бригадир, інакше не буде встановлено факт завершення будівництва
            foreach (var worker in Workers)
            {
                if (worker is Worker)
                    hasWorker = true;
                if (worker is TeamLeader)
                    hasLeader = true;
            }

            if (!hasWorker)
            {
                Console.WriteLine("Can't build without Worker");
                return false;
            }

            //if (!hasLeader)
            //{
            //    Console.WriteLine("Can't finish building withou TeamLeader");
            //    return false;
            //}

            return true;
        }

        public void BuildHouse(House house)
        {
            // перевірки перед будівництвом будинку
            if (!house.Validate())
                return;

            if (!Validate())
                return;

            // будівництво будинку продовждується поки він незавершений
            while (!house.IsReady)
            {
                bool someWorkWereDone = false;

                foreach (var worker in Workers)
                {
                    var donePart = worker.DoWork(house);
                    // якщо метод повернув непустий результат - якась робота виконувалася (будувалося, або робився звіт) - фіксуємо що щось робилося за цей день
                    if (donePart != null)
                        someWorkWereDone = true;
                }

                // якщо усі працівники відпрацювали день і нічого не зробили - значить усі роботи завершені, і виходимо із процесу будівництва
                if (!someWorkWereDone)
                {
                    Console.WriteLine("!!!!!!!!!!!! Stop building because no more work for team");
                    break;
                }
            }
        }
    }
}
