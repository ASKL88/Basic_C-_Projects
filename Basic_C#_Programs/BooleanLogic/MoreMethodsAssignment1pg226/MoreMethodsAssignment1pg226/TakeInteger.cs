using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethodsAssignment1pg226
{
    class TakeInteger
    {
        public int Math(int x)
        {
            return x * 3;
        }

        public decimal Math (decimal y)

        {
            return y + 10;
        }


        public string Math (string z)

        {
            int stringAnswer = Convert.ToInt32(z);

            int result = stringAnswer / 1;
            Console.WriteLine(result);
            return z;


        }

    }

}
