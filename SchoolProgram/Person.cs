using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    //A Person base class with common attributes for a person and an abstract class.
    abstract class Person
    {
        private string personName;
        public string Name
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        
    }
}
