using System;
using System.IO;

namespace BasicIOExample1
{
    class ReadNumbers3
    {
        public static int[] GetNumbers()
        {
            String[] lines = File.ReadAllLines(Program.readFilePath);
            int[] numbers = new int[lines.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(lines[i]);
            }

            return numbers;
        }
    }
}
