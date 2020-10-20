using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Faculties
    {
        string facName;
        int finance;
        List<Departments> deps = new List<Departments>();

        public Faculties(string fn, int f)
        {
            facName = fn;
            finance = f;
        }
        public override string ToString()
        {
            return "Факультет <<" +facName+ ">> з фінансуванням " + finance + " грн на рік";
        }
        public string FacultieName { get; set; }
        public int Finance { get; set; }
        public Departments Departments { get; set; }
    }
}
