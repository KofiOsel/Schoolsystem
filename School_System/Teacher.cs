using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    class Teacher : User
    {
        private List<Course> teachingCourses;

        public Teacher(List<Course> teachingCourses, string id, string name, string password) : base(id, name, password)
        {
            base.Id = id;
            base.Name = name;
            base.Password = password;
            TeachingCourses = teachingCourses;
        }

        public List<Course> TeachingCourses
        {
            get { return teachingCourses; }
            set { teachingCourses = value; }
        }
    }
}
