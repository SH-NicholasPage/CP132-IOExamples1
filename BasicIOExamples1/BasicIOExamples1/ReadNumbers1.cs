using System;
using System.IO;

namespace BasicIOExample1
{
    class ReadNumbers1
    {
        public static int[] GetNumbers()
        {
            FileStream fs = File.Open(Program.readFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            String[] lines = new String[0];
            int counter = 0;

            while (sr.EndOfStream == false)
            {
                String[] temp = new String[lines.Length + 1];

                for (int i = 0; i < lines.Length; i++)
                {
                    temp[i] = lines[i];
                }

                lines = temp;

                lines[counter++] = sr.ReadLine();
            }

            int[] numbers = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = Convert.ToInt32(lines[i]);
            }

            fs.Close();

            return numbers;
        }
    }
}
