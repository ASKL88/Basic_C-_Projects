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

        public int Math (decimal y)

        {
            int decimalAnswer = Decimal.ToInt32(y);
            int decimalresult =  decimalAnswer + 10;
            return decimalresult;
        }


        public int Math (string z)

        {
            int stringAnswer = Convert.ToInt32(z);
            int result = stringAnswer / 1;
            return result;


        }

    }

}
