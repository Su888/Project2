using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Course
    {
        public string CourseName { get; set; }

        Student[] Students = null;
        Teacher[] Teachers = null;

        public Course(string cname)
        {
            this.CourseName = cname;
            Students = new Student[3];
            Teachers = new Teacher[3];
        }

        int index = 0;

        public void AddStudent(Student s)
        {
            if (index <= 2)
            {
                Students[index] = s;
                index++;
            }
        }

        int index1 = 0;

        public void AddTeacher(Teacher t)
        {
            if (index1 <= 2)
            {
                Teachers[index1] = t;
                index1++;
            }
        }
        
        public int GetStudentCount()
        {
            return Students.Count();    
        }
    }
}
