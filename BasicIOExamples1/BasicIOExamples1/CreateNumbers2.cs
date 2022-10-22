using System;
using System.Collections.Generic;
using System.IO;

namespace BasicIOExample1
{
    class CreateNumbers2
    {
        public static void WriteNumbers(int[] numbers)
        {
            File.Create(Program.writeFilePath).Close();

            List<String> lines = new List<String>();

            foreach (int number in numbers)
            {
                lines.Add(number.ToString());
            }

            File.WriteAllLines(Program.writeFilePath, lines);
        }
    }
}
