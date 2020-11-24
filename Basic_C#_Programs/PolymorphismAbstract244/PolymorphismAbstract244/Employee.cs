using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract244
{
    public class Employee<T>: Person, IQuittable
    {
        public int Id { get; set; }

        public List<T> things { get; set; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I Quit");
        }

        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //    bool result = false;

        //    if (employee1.Id == employee2.Id)
        //    {
        //        result= true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    bool result = true;

        //    if (employee1.Id != employee2.Id)
        //    {
        //        result= true;
        //    }
        //    else
        //    {
        //        result = false;
        //    }
        //    return result;
    }
    }
