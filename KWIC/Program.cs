using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIC
{
    class Program
    {
        static void Main(string[] args)
        {

            Input input = new Input("Input.txt");
            Characters characters = new Characters(input.readLines());
            CircularShifter circularShifter = new CircularShifter(characters);
            Alphabetizer alphabetizer = new Alphabetizer(circularShifter);
            Output output = new Output("Output.txt");
            output.writeLines(alphabetizer);


            System.Console.ReadKey();
        }
    }
}
