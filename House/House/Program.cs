using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо проект будинку - екземпляр класу House, у якого заповнені усі частини, задано імена, але нічого не готове
            var house = new House
            {
                Name = "Modern house",

                Basement = new Basement { Type = BasementType.String, Name = "String Basement" },
                //Wall1 = new Wall { Name = "Wall1" },
                Wall1 = new Wall { Name = "Wall1" },

                Wall2 = new Wall { Name = "Wall2" },
                Wall3 = new Wall { Name = "Wall3" },
                Wall4 = new Wall { Name = "Wall4" },

                Door = new Door { Type = DoorType.Glass, Name = "Glass Door" },

                Window1 = new Window { Name = "Window1" },
                Window2 = new Window { Name = "Window2" },
                Window3 = new Window { Name = "Window3" },
                Window4 = new Window { Name = "Window4" },

                Roof = new Roof { Name = "Roof" },
            };

            // створюємо команду, в якій є працівники і бригадир
            var team = new Team
            {
                Name = "Cool team",

                Workers = new IWorker[]
                {
                    new Worker { Name = "Ivan" },
                    new Worker { Name = "Petro" },
                    new Worker { Name = "Sydor" },
                    new Worker { Name = "John Conor" },

                    // можна закоментарити цей рядок - і тоді команда буде без бригадира, а будівництво завершиться коли в працівників не буде більше роботи (метод DoWork повертатиме НАЛЛ)
                    new TeamLeader { Name = "Volodymyr" },
                },
            };

            team.BuildHouse(house);
        }
    }
}
