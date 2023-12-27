using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{

    class Modifier
    {
        // Private Modifier
        private void CircleArea(int r)
        {
            var b = 3.14 * r * r;
            Console.WriteLine("radius of circle is   " + b);
        }
        public void CalculateArea(float @base, float @height)
        {
            var res = 0.5 * @base * height;
           
            Console.WriteLine("radius of triangle is -" + res);
            CircleArea(6);
        }
        //Protected Modifier
        protected void Addition(int x, int y)
        {
            
            // name = "Pankaj";
            Console.WriteLine(x+y);
        }
        //public Modifier
        public void evenno()
        {
            Console.WriteLine("enter the mumber you  want to check");
            int k = Convert.ToInt32(Console.ReadLine());
            
            if ( k%2==0)
            {
                Console.WriteLine($"{k}  is Even number");
            }

            else
            {
                Console.WriteLine("number is Odd");
            }
        }

    }
    internal class derived : Modifier
    {
        public static void Main(string[] args)
        {
            Modifier p = new Modifier();
            p.CalculateArea(10, 10);
            derived d = new derived();
            d.Addition(10, 5);
            p.evenno();

        }
    }

}