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
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            

            Employee quit = new Employee();
            quit.Quit();
            Console.ReadLine();
        }
    }
}
