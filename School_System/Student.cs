using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    class Student : User
    {
        private List<String> regsCourses { get; set; }
        private List<String> grades { get; set; }


        public Student(List<String> regsCourses, string id, string name, string password, List<String> grades) : base(id, name, password)
        {
            base.Id = id;
            base.Name = name;
            base.Password = password;
            RegsCourses = regsCourses;
            Grades = grades;
        }

        public List<String> RegsCourses
        {
            get { return regsCourses; }
            set { regsCourses = value; }
        }
        public List<String> Grades
        {
            get { return grades; }
            set { grades = value; }
        }
    }
}
