using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace University1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate three Student objects.
            var student1 = new Student("Indiana", "Jones", new DateTime(1980, 6, 21));
            Student student2 = new Student("John", "Snow", new DateTime(1979, 10, 13));
            var student3 = new Student("Quentin", "Tarantino", new DateTime(1972, 11, 5));

            //Console.WriteLine(stud1.FirstName);

            //Instantiate a Course object called Programming with C#
            Course course1 = new Course("Programming with C#");

            //Add your three+1 students to this Course object.
            course1.addStudent(student1);
            course1.addStudent(student2);
            course1.addStudent(student3);
            course1.addStudent(new Student("John", "Malkovich", new DateTime(1982, 12, 22)));
            
            //Instantiate at least one Teacher object.
            Teacher Prof1 = new Teacher("Ibne", "Batoota", "Professor");

            //Add that Teacher object to your Course object.
            course1.addTeacher(Prof1);

            //Instantiate a Degree object, such as Bachelor.
            var fullBach1 = new Degree("Bachelor of Science", 4);

            //Add your Course object to the Degree object.
            fullBach1.addCourse(course1);
            //fullBach1.Course = course1;

            //Instantiate a UProgram object called Information Technology.
            //Add the Degree object to the UProgram object.
            UProgram stem1 = new UProgram("Information Technology", fullBach1);

            Console.WriteLine($"The first university program is {stem1.ProgName}.");
            Console.WriteLine($"It contains a degree called {fullBach1.Name}");
            Console.WriteLine($"{fullBach1.Name} has a course called {course1.Name}");
            Console.WriteLine($"The number of students in {course1.Name} is {Student.NumberOfStudents()}");
            Console.WriteLine("The names of the students are: ");
            for (int i = 0; i < course1.Students.Count; i++)
            {
                Console.WriteLine($"{course1.Students[i].FirstName} {course1.Students[i].LastName}");
            }
            Console.WriteLine("======================================");

            Console.WriteLine("Writing student details to file, reading details and disposing objects:\n");
            for (int i = 0; i < course1.Students.Count; i++)
            {
                Console.WriteLine($"{course1.Students[i].FirstName} {course1.Students[i].LastName}");
                course1.Students[i].WriteDetails(@"C:\Users\ahsan\Desktop\Progs\cSharp\University1\University1\bin\Debug\netcoreapp3.1\StucherInfo.txt");
                course1.Students[i].ReadDetails(@"C:\Users\ahsan\Desktop\Progs\cSharp\University1\University1\bin\Debug\netcoreapp3.1\StucherInfo.txt");
                course1.Students[i].Dispose();
            }
        }
    }
}
