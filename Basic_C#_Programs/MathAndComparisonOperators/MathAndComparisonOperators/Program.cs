using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
	class Program
	{
		static void Main(string[] args)
		{
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            ////Console.ReadLine();

            //double quotient = 100.00 / 17.00;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            ////Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //Console.WriteLine("What is your number?");
            //string number = Console.ReadLine();
            //int num = Convert.ToInt32(number);
            //int timesnumber = num * 50;
            //Console.WriteLine("Your Number * 50 = " + timesnumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your number?");
            //string secnumber = Console.ReadLine();
            //int secnum = Convert.ToInt32(secnumber);
            //int addnumber = secnum + 25;
            //Console.WriteLine("Your Number + 25 = " + addnumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your number?");
            //string thirdnumber = Console.ReadLine();
            //int thirdnum = Convert.ToInt32(thirdnumber);
            //double quotnumber = thirdnum / 12.5;
            //Console.WriteLine("Your Number / 12.5 = " + quotnumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your number?");
            //string fournumber = Console.ReadLine();
            //int fournum = Convert.ToInt32(fournumber);
            //bool trueOrFalse = fournum > 50;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //Console.WriteLine("What is your number?");
            //string fivenumber = Console.ReadLine();
            //int fivenum = Convert.ToInt32(fivenumber);
            //double modnumber = fivenum % 7;
            //Console.WriteLine(modnumber);
            //Console.ReadLine();


            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();



            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string pOneRate = Console.ReadLine();
            int pOneRateNum = Convert.ToInt32(pOneRate);

            Console.WriteLine("Hours worked per week?");
            string pOneHours = Console.ReadLine();
            int pOneHoursNum = Convert.ToInt32(pOneHours);




            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string pTwoRate = Console.ReadLine();
            int pTwoRateNum = Convert.ToInt32(pTwoRate);

            Console.WriteLine("Hours worked per week?");
            string pTwoHours = Console.ReadLine();
            int pTwoHoursNum = Convert.ToInt32(pTwoHours);

            Console.WriteLine("Annual salary of Person 1:");
            int pOneSalary = pOneRateNum * pOneHoursNum * 52;
            Console.WriteLine(pOneSalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int pTwoSalary = pTwoRateNum * pTwoHoursNum * 52;
            Console.WriteLine(pTwoSalary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2 ? ");
            bool compare = pOneSalary >= pTwoSalary;
            Console.WriteLine(compare);
            Console.ReadLine();

        }
    }
}
