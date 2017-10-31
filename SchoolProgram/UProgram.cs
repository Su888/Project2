using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class UProgram
    {
        public string ProgramName { get; set; }

        public UProgram(string pname)
        {
            this.ProgramName = pname;
        }

        Degree[] Degrees = new Degree[10];

        int index = 0;

        public void AddDegrees(Degree d)
        {
            Degrees[index] = d;
            index++;
        }
    }
}
