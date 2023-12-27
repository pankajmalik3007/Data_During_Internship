using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXPLICIT VARIABLE

            int p = 100;
            float f = 1.0f; //explicitly typed variable

            //IMPLICITLY VARIABLE
            //var keyword to declare method level variables without specifying a data type explicitly.

            int k = 10;
            var j = k + 1; //compiles as int

            var a = 10;
            Console.WriteLine("Type of i is {0}", a.GetType());

            var dbl = 150.678d;
            Console.WriteLine("Type of dbl is {0}", dbl.GetType());

            var str = ("Welcome to c#");
            Console.WriteLine("Type of str is {0}", str.GetType());

            var boolvar = true;
            Console.WriteLine("Type of boolvar is {0}", boolvar.GetType());

            var anony = new { name = "Pankaj" };
            Console.WriteLine("Type of anony is {0}", anony.GetType());


            var arr = new[] { 1, 2, 3, 4 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());


            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());

            var l = 9485768l;
            Console.WriteLine("Type of l  is{0} ",l.GetType());

            char fch = 'C';
            Console.WriteLine("type of fch is{0} ", fch.GetType());


        }
    }
}