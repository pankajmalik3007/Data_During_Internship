using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anony
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Anonymous type is type (Class) without any name that can contain public read only properties
            // we can create anonymous types using using new operator with an object initializer.

            var EmployeeData = new { passId = 1, FirstName = "Pankaj", Lastname = "Malik", mobno = 9284, Aadharno = 9801 };
            Console.WriteLine(EmployeeData.passId);
            Console.WriteLine(EmployeeData.FirstName);
            Console.WriteLine(EmployeeData.Lastname);
            Console.WriteLine(EmployeeData.mobno);
            Console.WriteLine(EmployeeData.Aadharno);



            //NESTED ANONYMOUS TYPE
            var student = new
            {
                Id = 1,
                FirstName = "Pankaj ",
                LastName = "Malik",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Address.Id);
            Console.WriteLine(student.Address.City);
            Console.WriteLine(student.Address.Country);


           
        }
        }
    }

