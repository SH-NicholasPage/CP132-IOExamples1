using System.IO;

namespace BasicIOExample1
{
    class CreateNumbers1
    {
        public static void WriteNumbers(int[] numbers)
        {
            FileStream fs = File.Create(Program.writeFilePath);//Creates or overwrites a file in the specified path.
            StreamWriter sw = new StreamWriter(fs);

            foreach (int number in numbers)
            {
                sw.WriteLine(number);
            }

            sw.Flush();//Do this after running
            fs.Close();
        }
    }
}
