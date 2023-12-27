using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Program
    {

        public Nullable<int> a = null;

        //Shorthand Syntax for Nullable Types
        // You can use the '?' operator to shorthand the syntax e.g. int?, long? instead of using Nullable<T>.
        public int? i = null;
        public int b = 10;

        static void Main(string[] args)
        {
            Program d = new Program();
            if (d.a == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(d.a);
            }


    }
    }
}
