using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace University1
{
    class Course
    {
       public string Name { get; set; }
       public List<Student> Students { get; set; }
       public List<Teacher> Teachers { get; set; }

        // Method to add a student.
        public void addStudent(Student student)
        {
            Students.Add(student);
        }

        // Method to add a teacher.
        public void addTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public Course(string courseName) {
            this.Name = courseName;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
    }
}
