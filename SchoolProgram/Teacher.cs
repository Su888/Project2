using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram 
{
    //Teacher class inherit from the Person base class.
    class Teacher : Person
    {
        public Teacher(string tname): base(tname)
        {
            
        }

        public string GradeTest()
        {
            return "this student is graded";
        }

    }
}
