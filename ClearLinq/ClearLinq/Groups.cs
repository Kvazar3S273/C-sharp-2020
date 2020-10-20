using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Groups
    {
        string groupName;
        int course;
        List<Teachers> teachs = new List<Teachers>();
        List<Faculties> facs = new List<Faculties>();

        public Groups(string gn, int c)
        {
            groupName = gn;
            course = c;
        }

        public override string ToString()
        {
            return "Група " + groupName + " " + course + "-й курс";
        }

        public string GroupName { get; set; }
        public int Course { get; set; }
        public Teachers Teachers { get; set; }
        public Faculties Faculties { get; set; }
    }
}
