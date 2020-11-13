using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "jesse";
            //string quote = "the man said , \\hello\", jesse.\n hello on a new line. \n \t hello on a new tab";
            //string filename = @"c:\users\jesse";


            //bool trueorfalse = name.contains("s");
            //trueorfalse = name.endswith("s");

            //int length = name.length;

            //name = name.tolower();

            //Console.writeline(name);
            //Console.readline();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            string greeting = "Hello ";
            string name = "Jack, ";
            string question = "how are you doing?";

            string sentence = greeting + name + question;

            name = name.ToUpper();

            Console.WriteLine(sentence);
            Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("I am 10 years old");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
