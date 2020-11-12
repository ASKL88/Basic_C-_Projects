using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your fav num");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 12 ? "You have an awesome fav num" : "You do not have an awesome fav num";

            Console.WriteLine(results);
            Console.ReadLine();





        //    int roomTemperature = 70;

        //    Console.WriteLine("Hi, what is your name?");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Hi " + name + ", what is the temperature where you are?");
        //    int currentTemperature = Convert.ToInt32(Console.ReadLine());

        //    if (currentTemperature == roomTemperature)
        //    {
        //        Console.WriteLine("It is exactly room temp");
        //    }
        //    else if (currentTemperature > roomTemperature)
        //    {
        //        Console.WriteLine("It is warmer than room temp");
        //    }
        //    else if (roomTemperature > currentTemperature)
        //    {
        //        Console.WriteLine("It is colder than room temp");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Something went wrong");
        //    }

        //    Console.Read();
            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResults = currentTemperature == roomTemperature ? "It is room remp" : "It is not room temp";

            //Console.WriteLine(comparisonResults);
            //Console.ReadLine();
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp");
            //}

            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");\
            
        }
    }
}
