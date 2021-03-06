﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Faculties
    {
        public Faculties(string facultieName, int finance)
        {
            FacultieName = facultieName;
            Finance = finance;
        }
        public override string ToString()
        {
            return "<<" + FacultieName + ">>";
        }
        public string FacultieName { get; set; }
        public int Finance { get; set; }
        public List<Departments> Departments { get; set; } = new List<Departments>();
    }
}
