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
            Employee employee1 = new Employee();

            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.Id = 1;
            employee1.SayName();

            Employee employee2 = new Employee();

            employee2.firstName = "Sample2";
            employee2.lastName = "Student2";
            employee2.Id = 2;
            employee2.SayName();

            Console.WriteLine(employee1 != employee2);

            Employee quit = new Employee();
            quit.Quit();
            Console.ReadLine();


        }



    }
    }
