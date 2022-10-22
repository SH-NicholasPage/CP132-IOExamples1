using System.IO;

namespace BasicIOExample1
{
    class WriteNumber2
    {
        public static void WriteNumber(int numberToAdd)
        {
            File.AppendAllText(Program.readFilePath, numberToAdd + "\n");
        }
    }
}
