using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Teachers
    {
        string surname;
        string name;
        int salary;
        List<Departments> depart = new List<Departments>();

        public Teachers(string sn, string n, int s)
        {
            surname = sn;
            name = n;
            salary = s;
        }

        public override string ToString()
        {
            return surname + " " + name + " з/п " + salary;
        }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Departments Depart { get; set; }

    }
}
