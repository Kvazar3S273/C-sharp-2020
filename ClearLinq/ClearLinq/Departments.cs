using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Departments
    {
        public Departments(string departmentName, int finance)
        {
            DepartmentName = departmentName;
            Finance = finance;
        }

        public override string ToString()
        {
            return "Кафедра <<" + DepartmentName + ">> з фінансуванням " + Finance + " грн на рік";
        }

        public string DepartmentName { get; set; }
        public int Finance { get; set; }
        public List<Groups> Groups { get; set; } = new List<Groups>();
    }
}
