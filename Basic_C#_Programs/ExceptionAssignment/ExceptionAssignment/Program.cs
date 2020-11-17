using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numbers = new List<int>() { 99, 85, 14, 75, 66, 34 };

                Console.WriteLine("Pick a number to divide by.");
                int divNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int input in numbers)
                {
                    Console.WriteLine(input / divNumber);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            finally
            {
                Console.WriteLine("Continuing...");
                Console.ReadLine();
            }

        }
    }
}
