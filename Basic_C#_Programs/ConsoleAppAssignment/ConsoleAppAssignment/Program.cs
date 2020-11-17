using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //PART ONE
            //List<string> Cars = new List<string>() { "Mazda.", "Toyota.", "Ford." };

            //Console.WriteLine("Please write some text.");

            //string text = Console.ReadLine();

            //foreach (string car in Cars)
            //{
            //    Console.WriteLine(car + " " + text);
            //    Console.ReadLine();
            //}



            //PART TWO

            //int count = 0;

            //while (true)
            //{
            //    Console.WriteLine("Count = 0.", count);
            //    count++;

            //    if (count >10)
            //    {
            //        break;
            //    }
            //}



            //PART THREE

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();


            //int x = 0;
            //while (x <= 5)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //Console.ReadLine();

            //PART FOUR

            //List<string> Fruits = new List<string>() { "Banana", "Apple", "Berry", "Grape", "Orange" };

            //Console.WriteLine("Please search for a fruit");
            //string answer = Console.ReadLine();

            //for (int i = 0; i < Fruits.Count; i++)
            //{
            //    if (answer == Fruits[i])
            //    {
            //        Console.WriteLine("Match found at: " + i);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Match not found");
            //    }
            //}
            //Console.ReadLine();

            //PART FIVE

            //List<string> Cars = new List<string>() { "Tesla", "Ford", "Chevy", "Toyota", "Tesla" };

            //Console.WriteLine("Please search for a car");
            //string carAnswer = Console.ReadLine();


            //for (int x = 0; x < Cars.Count; x++)
            //{
            //    if (carAnswer == Cars[x])
            //    {
            //        Console.WriteLine("Match found at: " + x);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Match not found");

            //    }
            //}
            //Console.ReadLine();

            //PART SIX

            List<string> Vegetables = new List<string>() { "Broccoli", "Celery", "Carrot", "Pea", "Carrot" };

            List<string> VegTemp = new List<string>();

            foreach (string veggies in Vegetables)
            {
                foreach (string temp in VegTemp)
                {

                    if (veggies == temp)
                    {
                        Console.WriteLine(veggies + " has appeared before in the list.");
                    }

                }
                VegTemp.Add(veggies);
            }
            Console.ReadLine();
        }
    }
}
