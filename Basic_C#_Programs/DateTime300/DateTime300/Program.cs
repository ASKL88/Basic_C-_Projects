using System;

namespace DateTime300
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());

            DateTime currentnow = DateTime.Now.AddHours(answer);
            Console.WriteLine(currentnow);
            Console.ReadLine();





        }
    }
}
