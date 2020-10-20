using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Departments
    {
        string depName;
        int finance;
        List<Groups> groups = new List<Groups>();
        public Departments(string dn, int f)
        {
            depName = dn;
            finance = f;
        }

        public override string ToString()
        {
            return "Кафедра <<" + depName + ">> з фінансуванням " + finance + " грн на рік";
        }

        public string DepartmentName { get; set; }
        public int Finance { get; set; }
        public Groups Groups { get; set; }
    }
}
