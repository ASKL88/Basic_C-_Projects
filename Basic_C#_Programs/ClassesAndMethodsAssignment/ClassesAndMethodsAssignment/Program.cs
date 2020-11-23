using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose a number to do operations");
            string answer = Console.ReadLine();
            int intAnswer = Convert.ToInt32(answer);

            Integer myObj = new Integer();
            //int i = a.First(intAnswer);
            //int j = a.Second(intAnswer);
            //int k = a.Third(intAnswer);

            Console.WriteLine(myObj.First(intAnswer));
            //Console.WriteLine(j);
            //Console.WriteLine(k);
            Console.ReadLine();

                
        }
    }
}
