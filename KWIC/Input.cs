using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class Input
    {
        public String FileName { get; set; }

        public Input()
        {
        }

        public Input(String fileName) 
        {
            FileName = fileName;
        }

        public List<String> readLines()
        {
            List<String> lines = new List<string>();

            lines = File.ReadAllLines(@FileName).ToList();

            return lines;
        }

    }
}
