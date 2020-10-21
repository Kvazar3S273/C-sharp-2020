using System;
using System.Collections.Generic;
using System.Text;

namespace ClearLinq
{
    class Groups
    {
        public Groups(string groupName, int course)
        {
            GroupName = groupName;
            Course = course;
        }

        public override string ToString()
        {
            //return "Група " + GroupName + " " + Course + "-й курс";
            return GroupName;

        }

        public string GroupName { get; set; }
        public int Course { get; set; }
        public List<Teachers> Teachers { get; set; } = new List<Teachers>();
        public List<Faculties> Faculties { get; set; } = new List<Faculties>();
    }
}
