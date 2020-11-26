using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AdditionFeatures310
{
    class Program
    {
        static void Main(string[] args)
        {
            const string playerName = "Mark";
            var name = new Name("Jesse", 2);

            Console.WriteLine(name.Player, name.Number);
            Console.WriteLine(playerName);
            Console.ReadLine();
        }
    }
}
