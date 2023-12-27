using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    delegate bool IsTeenAger(Student student);
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

       
    }
    class Program
    {


        //Data Source
        static void Main(string[] args)
        {
            Console.WriteLine("Using Array.......................");
            string[] studentname = { "Pankaj", "pavan", "pratik", "sagar" };


            //LINQ Query
            var linqQuery = from studentnames in studentname
                            where studentnames.Contains('k')
                            select studentnames;


            //Query Exucation
            foreach (var studentnames in linqQuery)
            {
                Console.WriteLine(studentnames + " ");
            }


            Console.WriteLine("Using List..........................");
            IList<string> list = new List<string>()
            {
                "India is a Country",
                "maharashtra is State",
                "Africa is a Country",
                "Mexico is a State"

            };
            Console.WriteLine("This is for Country ................");
            var result = from city in list
                         where city.Contains("Country")
                         select city;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("This is for State ................");
            var result1 = from city in list
                          where city.Contains("State")
                          select city;

            foreach (var str in result1)
            {
                Console.WriteLine(str);
            }


            //Lambda Expression In c#
            Console.WriteLine("Lambda Expression In c#...........");
            IsTeenAger isTeenAger = s => s.age > 12 && s.age < 20;

            Student student = new Student() 
            { 
                age = 15 
            };

            Student studen1t = new Student()
            {
                age = 25
            };

            Console.WriteLine(isTeenAger(student));
            Console.WriteLine(isTeenAger(studen1t));

       
        }
    }
}

