using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 6;
            bool isEven;

           
            //First Way
            isEven = (num % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

           
            
            //Second Way

            Console.WriteLine((num % 2 == 0) ? true : false);
        }
    }
}
