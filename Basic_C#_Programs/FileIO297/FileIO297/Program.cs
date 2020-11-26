using System;
using System.IO;

namespace FileIO297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\Users\AL\Desktop\log.txt", answer);

            string readText = File.ReadAllText(@"C:\Users\AL\Desktop\log.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
