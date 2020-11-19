using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods231
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer a = new Integer();

            Console.WriteLine("Choose a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            a.Math(num1);
            Console.ReadLine();
        }
    }
}
