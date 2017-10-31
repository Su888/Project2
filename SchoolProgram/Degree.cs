using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Degree
    {
        public string DegreeName;
        
        public Degree(string dname)
        {
            this.DegreeName = dname;
        }

        Course[] Courses = new Course[10];

        int index = 0;

        public void AddCourses(Course c)
        {
            Courses[index] = c;
            index++;
        }

    }
}
