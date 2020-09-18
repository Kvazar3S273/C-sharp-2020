using System;
using System.Text;

namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //створюємо проект будинку - екземпляр класу House, у якого заповнені усі частини, задано імена, але нічого не готове
            var house = new House
            {
                Name = "КОТЕДЖ",

                Basement = new Basement { Type = BasementType.String, Name = "Стрічковий фундамент" },
                
                Wall1 = new Wall { Name = "Стіна 1" },
                Wall2 = new Wall { Name = "Стіна 2" },
                Wall3 = new Wall { Name = "Стіна 3" },
                Wall4 = new Wall { Name = "Стіна 4" },

                Door = new Door { Type = DoorType.Glass, Name = "Скляні двері" },

                Window1 = new Window { Name = "Вікно 1" },
                Window2 = new Window { Name = "Вікно 2" },
                Window3 = new Window { Name = "Вікно 3" },
                Window4 = new Window { Name = "Вікно 4" },

                Roof = new Roof { Name = "Дах" },
            };

            //створюємо команду, в якій є працівники і бригадир
            var team = new Team
            {
                Name = "Таджики",

                Workers = new IWorker[]
                {
                    new Worker { Name = "Равшан" },
                    new Worker { Name = "Джамшуд" },
                    new Worker { Name = "Гурген" },
                    new Worker { Name = "Махрам" },

                    new TeamLeader { Name = "Степан Петрович" },
                },
            };

            team.BuildHouse(house);
        }
    }
}
