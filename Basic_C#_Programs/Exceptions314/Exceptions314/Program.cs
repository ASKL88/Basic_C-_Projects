using System;

namespace Exceptions314
{
    class Program
    {
        static void CheckFor(int number)
        {
            if (number < 1)
            {
                throw new NoNegative("Zero or Negative number is not allowed");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int answer = Convert.ToInt32(Console.ReadLine());
                CheckFor(answer);
                var year = DateTime.Now.Year;
                int numYear = Convert.ToInt32(Convert.ToString(year));
                Console.WriteLine("Birth Year: " + (numYear - answer));
                Console.ReadLine();
            }
            catch (NoNegative)
            {
                Console.WriteLine("You must enter a number greater than zero");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("You made an error.");
                Console.ReadLine();
                return;
            }
        }
    }
}
