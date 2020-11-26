using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda272
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {firstName = "Joe", lastName = "Smith", ID = 1},
                new Employee {firstName = "Jack", lastName = "Doe", ID = 2},
                new Employee {firstName = "Jane", lastName = "Doe", ID = 3},
                new Employee {firstName = "Malcom", lastName = "Brown", ID = 4},
                new Employee {firstName = "Will", lastName = "Green", ID = 5},
                new Employee {firstName = "Mary", lastName = "Part", ID = 6},
                new Employee {firstName = "Perry", lastName = "Jack", ID = 7},
                new Employee {firstName = "Robert", lastName = "Grey", ID = 8},
                new Employee {firstName = "John", lastName = "James", ID = 9},
                new Employee {firstName = "Joe", lastName = "James", ID = 10}
            };

            List<Employee> newList = employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee emp in newList)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName);
            }
            //foreach (Employee emp in employees)
            //{   
            //    if (emp.firstName == "Joe")
            //    {
            //        newList.Add(emp);
            //        Console.WriteLine(emp.firstName + " " + emp.lastName);
            //    }
            //}

            List<Employee> newIDList = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee emp in newIDList)
            {
                Console.WriteLine(emp.ID);
            }
            Console.ReadLine();
        }
    }
}
