using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
            }

            else if (weight < 50)
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package width:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package width:");
                int length = Convert.ToInt32(Console.ReadLine());

                int dimensions = width + height + length;

                if (dimensions > 50)
                {
                    Console.WriteLine("“Package too big to be shipped via Package Express.” ");
                    Console.ReadLine();
                }

                else if (dimensions < 50)
                {
                    int quote = (width * height * length * weight) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote + ".00");
                    Console.WriteLine("Thank you!");

                    Console.ReadLine();
                }
            }
        }
    }
}
