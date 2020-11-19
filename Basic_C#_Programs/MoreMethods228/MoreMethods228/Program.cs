using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods228
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoIntegers a = new TwoIntegers();

            Console.WriteLine("Choose first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose second number");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            a.Math(num1, num2);
            Console.ReadLine();

            a.Math(x:2, y:3);
            Console.ReadLine();
        }
    }
}
