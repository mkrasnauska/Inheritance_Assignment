using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var Person = new Person();

            Person.SayName();

            var Employee = new Employee();

            Employee.FirstName = "Student";
            Employee.LastName = "Sample";
            Employee.SayName();

            {
                Console.ReadLine();

            }
        }
    }
}
