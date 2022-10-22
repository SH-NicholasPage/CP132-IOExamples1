using System;
using System.IO;

namespace BasicIOExample1
{
    class Program
    {
        public const String readFilePath = "C:/Users/nickp/Downloads/inputs.txt";//Mac: /Users/<username>/Downloads
        public const String writeFilePath = "C:/Users/nickp/Downloads/output.txt";

        static void Main()
        {
            if (File.Exists(readFilePath) == false)
            {
                Console.Error.WriteLine("ERROR: Input file not found!");
                return;
            }

            int[] numbers;
            //numbers = ReadNumbers1.GetNumbers();
            //numbers = ReadNumbers2.GetNumbers();
            numbers = ReadNumbers3.GetNumbers();
            PrintNumbers(numbers);

            int newNumber = Random.Shared.Next(0, 101);
            Console.WriteLine("\nAdding " + newNumber + " to " + readFilePath + "...");
            //WriteNumber1.WriteNumber(newNumber);
            WriteNumber2.WriteNumber(newNumber);

            SortNumbers(numbers);
            //CreateNumbers1.WriteNumbers(numbers);
            //CreateNumbers2.WriteNumbers(numbers);

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void SortNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}