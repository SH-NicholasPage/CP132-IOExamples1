using System;
using System.Collections.Generic;
using System.IO;

namespace BasicIOExample1
{
    class ReadNumbers2
    {
        public static int[] GetNumbers()
        {
            FileStream fs = File.Open(Program.readFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            List<Int32> numbers = new List<Int32>();

            while (sr.EndOfStream == false)
            {
                numbers.Add(Convert.ToInt32(sr.ReadLine()));
            }

            fs.Close();

            return numbers.ToArray();
        }
    }
}
