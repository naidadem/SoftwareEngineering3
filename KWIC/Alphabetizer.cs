using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Alphabetizer
    {
        public List<String> Lines { get; set; }
        public CircularShifter Shifter { get; set; }

        public Alphabetizer() 
        { 
        }

        public Alphabetizer(CircularShifter shifter) 
        {
            Shifter = shifter;

            Lines = alphabetize(Shifter.getShiftedLines());
        }

        private List<string> alphabetize(List<string> lines)
        {
            lines.Sort();
            return lines;
        }

        public List<String> getLines() 
        {
            return Lines;
        }

    }
}
