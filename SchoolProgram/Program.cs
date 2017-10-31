using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a Course and and assign value.
            Course c = new Course("Programming with C#");

            //Instantiate three Student objects and assign values to them. Add these three students to the Course object.
            c.AddStudent(new Student("ppp"));
            c.AddStudent(new Student("qqq"));
            c.AddStudent(new Student("rrr"));

            //Instantiate a Teacher object.
            Teacher t = new Teacher("abcd");

            //Add the Teacher object to the Course object.
            c.AddTeacher(t);
            
            //Instantiate a Degree object.
            Degree d = new Degree("Bachelor");

            //Add the Course object to the Degree object.
            d.AddCourses(c);

            //Instantiate a UProgram object.
            UProgram u = new UProgram("Information Technology");

            //Add the Degree object to the UProgram object.
            u.AddDegrees(d);

            //Print result.
            Console.WriteLine($"The name of the program is '{u.ProgramName}' and the degree offered for this program is '{d.DegreeName}'.");
            Console.WriteLine($"The name of the course '{c.CourseName}' in the degree '{d.DegreeName}'.");
            Console.WriteLine($"The count of the number of students registered for the course '{c.CourseName}' is: '{c.GetStudentCount()}'.");

            Console.Read();
        }

    }
}
