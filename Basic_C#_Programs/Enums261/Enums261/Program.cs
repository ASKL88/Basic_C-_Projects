using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums261
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            string Answer = Console.ReadLine();

            DaysOfTheWeek day;
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Answer);

                Console.WriteLine(day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.ReadLine();
        }

    }
}
