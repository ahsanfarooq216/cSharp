using System;
using System.Collections.Generic;
using System.Text;

namespace University1
{
    class Degree
    {
        public string Name { get; set; }
        public int ProgLength { get; set; }
        public Course Course { get; set; }
        public List<Course> Courses { get; set; }

        public Degree(string degreeName, int progLength)
        {
            this.Name = degreeName;
            this.ProgLength = progLength;
            this.Courses = new List<Course>();
        }
        public void addCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
