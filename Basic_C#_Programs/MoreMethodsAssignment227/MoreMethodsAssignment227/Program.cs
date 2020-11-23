using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethodsAssignment227
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoInt a = new TwoInt();

            Console.WriteLine("Choose two numbers, Second number is optional ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number is optional ");
            int y = Convert.ToInt32(Console.ReadLine());

            //int y;
            //int results;

            //if (int.TryParse(Console.ReadLine(), out y))
            //{
            //    results = a.Math(x, y);
            //}
            //else
            //{
            //    results = a.Math(x);
            //}

            Console.WriteLine(a.Math(x, y));

            //Console.WriteLine("Answer is: " + results);
            Console.ReadLine();
        }
    }
}
