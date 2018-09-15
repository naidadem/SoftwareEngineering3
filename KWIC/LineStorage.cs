using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{

    public class Characters
    {
        public List<String> Lines { get; set; }

        public Characters(List<String> lines) 
        {
            Lines = lines;
        }

        public void charSet(List<String> characters)
        {
            Lines = characters;    
        }

        public List<String> getLines() 
        {
            return Lines;
        }
    }
}
