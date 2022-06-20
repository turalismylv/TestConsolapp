using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Group
    {
        public string  Name { get; set; }
        public int  Number { get; set; }
        public List<Student> students;
        public int Id { get; }
        public static int _id;

        public Group()
        {

        }
        public Group(string name,int number):this()
        {
            Name = name;
            Number = number;
            students = new List<Student>();
            Id = ++_id;
        }
    }
}
