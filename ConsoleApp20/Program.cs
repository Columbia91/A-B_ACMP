using System;
using System.IO;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ADILET\source\repos\ConsoleApp20\ConsoleApp20\input.txt");
            
            string[] numbers = sr.ReadToEnd().Split();

            StreamWriter sw = new StreamWriter(@"C:\Users\ADILET\source\repos\ConsoleApp20\ConsoleApp20\output.txt");

            sw.WriteLine(int.Parse(numbers[0]) + int.Parse(numbers[1]));
            sw.Close();
        }
    }
}
