using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Program
    {
        // ONE INTERFACE TWO CLASSES
        interface IArithmetic
        {
            void calculation();
        }

        public class add : IArithmetic
        { 
            public void calculation() 
            {
                int a = 8;
                int b = 20;
                int result = a + b;
                Console.WriteLine(result);
            }
        }
         public class subtract : IArithmetic
        {
            public void calculation()
            {
                int a = 14;
                int b = 11;
                Console.WriteLine(a - b);
            }
        }



        static void Main(string[] args)
        {
            add sum = new add();
            sum.calculation();

            subtract sub = new subtract();
            sub.calculation();
        }
    }
}
