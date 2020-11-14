using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArray = new string[3];
            stringArray[0] = "Hello";
            stringArray[1] = "My Name Is";
            stringArray[2] = "Jack";

            Console.WriteLine("Please select an index of the Array.");

            string answer = Console.ReadLine();
            int answerNum = Convert.ToInt32(answer);
            if (answerNum>3 || answerNum<0)
            {
                Console.WriteLine("This is an error.");
                Console.ReadLine();
            }
            else
            { 
            Console.WriteLine(stringArray[answerNum]);
            Console.ReadLine();
            }


            int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };

            Console.WriteLine("Please select an index of the Array.");

            string intAnswer = Console.ReadLine();
            int intAnswerNum = Convert.ToInt32(intAnswer);

            if (intAnswerNum > 6 || answerNum < 0)
            {
                Console.WriteLine("This is an error.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[intAnswerNum]);
                Console.ReadLine();
            }


            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("I am");
            intList.Add("Mark");


            Console.WriteLine("Please select an index of the List.");

            string listAnswer = Console.ReadLine();
            int listAnswerNum = Convert.ToInt32(listAnswer);
            Console.WriteLine(intList[listAnswerNum]);
            Console.ReadLine();



        }
    }
}
