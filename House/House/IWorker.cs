using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    interface IWorker
    {
        public string NamePart { get; set; }
        public void Working()
        {
            Console.WriteLine("The employee is working");
        }
        public bool Check()
        {
            return true;
        }
    }

    class Worker : IWorker
    {
        public string NamePart { get; set; } = "Worker";
        public void Working()
        {
            Console.WriteLine("The worker is working");
        }
        public bool Check()
        {
            if (true)
            {
                return true;
            }
            
        }
    }

    class Brigadir : IWorker
    {
        public string NamePart { get; set; } = "Brigadir";
        public void Working()
        {
            Console.WriteLine("The brigadir is working");
        }
        public bool Check()
        {
            if (true)
            {
                return true;
            }
            
        }
    }

    class Team : IWorker
    {
        public string NamePart { get; set; } = "Team";
        public void Working()
        {
            Console.WriteLine("The team is working");
        }
        public bool Check()
        {
            if (true)
            {
                return true;
            }
            
        }
    }
}
