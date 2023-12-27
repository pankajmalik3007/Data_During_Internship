using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {

        // SINGLE INTERFACE AND SINGLE CLASS
        
        interface Imul
        {
            void calculateArea(int l, int b);
        }

        class Rectangle : Imul
        {
            public void calculateArea(int l, int b)
            {
                int area = l * b;
                Console.WriteLine("Area of Rectangle: " + area);
            }
        }
            static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            r.calculateArea(10, 15);

        }
    }
}
