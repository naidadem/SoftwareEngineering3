using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Output
    {
        public String FileName { get; set; }

        public Output()
        { 
        }

        public Output(String fileName)
        {
            FileName = fileName;
        }

        public void writeLines(Alphabetizer alphabetizer) {

            var lines = alphabetizer.getLines();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@FileName))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
