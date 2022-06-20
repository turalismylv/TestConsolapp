using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public string Zemanet { get; set; }
        public int Id { get; }
        public static int _id;
        public Student()
        {

        }
        public Student(string name,string surname,string fathername,int age,string group,string zemanet):this()
        {
            Id = ++_id;
            Name = name;
            Surname = surname;
            Fathername = fathername;
            Age = age;
            Group = group;
            Zemanet = zemanet;
        }
    }
}
