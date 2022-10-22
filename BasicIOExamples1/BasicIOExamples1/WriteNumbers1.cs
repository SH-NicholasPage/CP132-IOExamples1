using System.IO;

namespace BasicIOExample1
{
    class WriteNumber1
    {
        public static void WriteNumber(int numberToAdd)
        {
            FileStream fs = File.Open(Program.readFilePath, FileMode.Append);
            StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(numberToAdd);
            sr.Flush();//Wait on this line

            fs.Close();
        }
    }
}
