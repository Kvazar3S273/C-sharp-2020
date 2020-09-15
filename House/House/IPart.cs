using System;

namespace House
{
    interface IPart
    {
        public string NamePart { get; set; }
        public void Build()
        {
            Console.WriteLine("Building process");
        }
        public bool Ready()
        {
            return true;
        }
    }

    class House : IPart
    {
        public string NamePart { get; set; } = "House";
        public void Build()
        {
            Console.WriteLine("House has builded!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Basement : IPart
    {
        public string NamePart { get; set; } = "Basement";
        public void Build()
        {
            Console.WriteLine("Basement has builded!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Wall : IPart
    {
        public string NamePart { get; set; } = "Wall";
        public void Build()
        {
            Console.WriteLine("Walls has builded!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Door : IPart
    {
        public string NamePart { get; set; } = "Door";
        public void Build()
        {
            Console.WriteLine("Door has instalated!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Window : IPart
    {
        public string NamePart { get; set; } = "Window";
        public void Build()
        {
            Console.WriteLine("Window has instalated!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Roof : IPart
    {
        public string NamePart { get; set; } = "Roof";
        public void Build()
        {
            Console.WriteLine("Roof has builded!");
        }
        public int ready = 0;
        public bool Ready(int ready)
        {
            if (ready == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
