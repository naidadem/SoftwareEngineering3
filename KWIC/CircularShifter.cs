using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    public class CircularShifter
    {
        public List<String> Lines { get; set; }
        public Characters Characters { get; set; }

        public CircularShifter() 
        {
            Lines = new List<string>();
        }

        public CircularShifter(Characters characters) 
        {
            Lines = circularShift(characters.getLines());
        }

        private List<string> circularShift(List<string> lines)
        {
            List<String> result = new List<String>();
            foreach (var line in lines)
            {
                List<String> words = new List<String>();
                words = line.Split().ToList();

                int lastIndex = words.Count - 1;
                for (int i = 0; i < words.Count; i++)
                {
                    var element = words.ElementAt(lastIndex);
                    words.RemoveAt(lastIndex);
                    words.Insert(0, element);
                    result.Add(String.Join(" ", words.ToArray()));
                }
            }

            return result;
        }

        public List<String> getShiftedLines() {

            return Lines;
        }

    }
}
