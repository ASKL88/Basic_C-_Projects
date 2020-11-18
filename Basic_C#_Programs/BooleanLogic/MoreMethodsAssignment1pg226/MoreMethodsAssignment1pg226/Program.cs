using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethodsAssignment1pg226
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to do operations");
            string answer = Console.ReadLine();
            int intAnswer = Convert.ToInt32(answer);

            TakeInteger a = new TakeInteger();
            int i = a.Math(intAnswer);

            Console.WriteLine(i);
            Console.ReadLine();

            Console.WriteLine("Choose a decimal to do operations");
            string decimalAnswer = Console.ReadLine();
            decimal decimalConvert = Convert.ToDecimal(decimalAnswer);
            decimal j = a.Math(decimalConvert);


            Console.WriteLine(j);
            Console.ReadLine();



            Console.WriteLine("Choose a number");
            string k = Console.ReadLine();
            a.Math(k);

            Console.WriteLine(k);
            Console.ReadLine();


        }
    }
}
