using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            int i = 10;
            Console.WriteLine("Numbers Are in reverse Order: ");
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            int k= 100;

            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine("Even No -",k);
                }
                else
                {
                    Console.WriteLine("odd no");
                }
             
            } while (k <= 50); 
        }
        }
    }


