using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    class Course
    {
        private String courseId;
        private String name { get; set; }
        private int maxAmount { get; set; }
        private Teacher teacher { get; set; }
        private List<Student> regsStudents { get; set; }
        private List<Double> scores { get; set; }
        private static int nextId = 0;

        public Course(string courseId, string name, int maxAmount, Teacher teacher)
        {
            CourseId = courseId;
            Name = name;
            MaxAmount = maxAmount;
            Teacher = teacher;
            RegsStudents = new List<Student>();
            Scores = new List<double>();
        }

        public String CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }

        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public List<Student> RegsStudents
        {
            get { return regsStudents; }
            set { regsStudents = value; }
        }

        public List<double> Scores
        {
            get { return scores; }
            set { scores = value; }
        }
    }
}
