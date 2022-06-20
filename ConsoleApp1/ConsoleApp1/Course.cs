using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Course
    {
        public string Name { get; set; }
        public List<Group> groups;
        public List<Student> students;

        public Course(string name)
        {
            Name = name;
            groups = new List<Group>();
            students = new List<Student>();
        }
    }
}
