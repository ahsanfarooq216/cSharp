using System;
using System.Collections.Generic;
using System.Text;

namespace University1
{
    class UProgram
    {
        public string ProgName { get; set; }
        public Degree Degree { get; set; }

        public UProgram(string progName, Degree degree) {
            this.ProgName = progName;
            this.Degree = degree;
        }
    }
}
