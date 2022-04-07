using System;
using System.IO;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            File_txt();
            BNum();
        }

        static void File_txt()
        {
            string filename = "startup.txt";
            Console.WriteLine("Напишите текст");
            string text = Console.ReadLine();
            File.WriteAllLines(filename, new[] { text, DateTime.Now.ToString() });

            string[] fileLines = File.ReadAllLines(filename);
            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i]);
            }
        }

        static void BNum()
        {
            Console.WriteLine("Напишите набор чисел");
            string[] numbers = Console.ReadLine().Split();
            byte[] array = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = Convert.ToByte(numbers[i]);
            }
            File.WriteAllBytes("bytes.bin", array);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");

            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.WriteLine(fromFile[i]);
            }
        }
    }
}
