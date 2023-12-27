using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("enter any no");
            int s = Convert.ToInt32(Console.ReadLine());
            //int i=1 ;
            int no;

            for (int i = 1; i < s; i++)
            {
                //    Console.WriteLine(i * i);
                no = i * i;
                Console.WriteLine(no);
            }
            
            Console.WriteLine("enter any no");
            int s = Convert.ToInt32(Console.ReadLine());

            int sum=0;
            //int a;
           for(int i = 1; i <=s; i++)
            {
                sum = sum + i; 
                
            }
            Console.WriteLine(sum);

            */
            Console.WriteLine("enter any no");
            int s = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            {
                for(int i = 1; i <=s; i++)
                {
                    fact= fact*i;
                   
                }
                Console.WriteLine(fact);

            }


        }
    }
}
