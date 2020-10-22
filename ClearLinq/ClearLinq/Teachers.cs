using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Teachers
    {
        public Teachers(string surname, string name, int salary)
        {
            Surname = surname;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Surname + " " + Name;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public List<Departments> Departments { get; set; } = new List<Departments>();

    }
}
