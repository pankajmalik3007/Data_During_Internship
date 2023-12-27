using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) student = ("Pankaj", 5, "Malik");
            Console.WriteLine(student);



            // create a tuple containing 3 elements 
            var programming = Tuple.Create("Pankaj", "Malik", 12);
            Console.WriteLine(programming);



            //Accessing Value of element only
            // access the first element 
            Console.WriteLine("The first element is " + student.Item1);
            // access the second element
            Console.WriteLine("The second element is " + student.Item2);
        


            // changing Value 
            student.Item1 = "Prathmesh";
            Console.WriteLine("After Changing value of Item1 - " );
            Console.WriteLine(student);



            //Nested Tuple
            var myTuple = Tuple.Create("Pankaj", "Malik", Tuple.Create(7, 8, 9));
            Console.WriteLine("The elements inside myTuple: " + myTuple);
            //Accessing Element of 2nd Tuple
            Console.WriteLine(myTuple.Item3.Item1);

        }
    }
}
