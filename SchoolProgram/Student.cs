using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    //Student class inherit from the Person base class.
    class Student : Person
    {
        public Student(string sname): base(sname)
        {
            
        }

        // Method TakeTest.
        public string TakeTest()
        {
            return "this student has taken the test";
        }
    }
}
