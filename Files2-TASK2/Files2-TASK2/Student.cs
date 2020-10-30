using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace Files2_TASK2
{
    [DataContract]
    class Student
    {
        public Student(string surname, string name, string group)
        {
            Surname = surname;
            Name = name;
            Group = group;
        }

        public override string ToString()
        {
            return Surname + " " + Name + " " + Group;
        }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Group { get; set; }
    }
}
