using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods231
{
    class Integer
    {
        public void Math(int x)
        {
            int results = x / 2;
            Console.WriteLine(results);
        }

        public static void Output(out int i)
        {
            i = 30;
            Console.WriteLine(i);
        }

        public static void Output(int z)
        {
            int number2 = z;
            Console.WriteLine(number2);
        }
    }
}
