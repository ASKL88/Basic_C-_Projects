using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract244
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.things = new List<string> { "Thing 1", "Thing2", "Thing3" };

            Employee<int> employee2 = new Employee<int>();
            employee2.things = new List<int> { 1, 2, 3 };

            foreach (var Temp in employee1.things)
            {
                Console.WriteLine(Temp);
            }
            foreach (var Temp in employee2.things)
            {
                Console.WriteLine(Temp);
            }

            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.Id = 1;
            employee1.SayName();

            employee2.firstName = "Sample2";
            employee2.lastName = "Student2";
            employee2.Id = 2;
            employee2.SayName();

            //Console.WriteLine(employee1 != employee2);

            //Employee quit = new Employee();
            //quit.Quit();
            Console.ReadLine();
        }



    }
    }
