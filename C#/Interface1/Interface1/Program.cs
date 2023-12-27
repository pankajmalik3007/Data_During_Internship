using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Program
    {
        //USING TWO INTERFACES AND ONE CLASS
        interface IAdd1
        {
            void add(int x, int y);
        }

        interface ISub2
        {
            void sub(int a, int b);
        }

        class Calculation : IAdd1, ISub2
        {
            public void add(int x, int y)
            {
                int add = x + y;
                Console.WriteLine("The Addition of two no is =" + add);
            }
            public void sub(int a, int b)
            {
                int sub = a - b;
                Console.WriteLine("The Substraction of two no is =" + sub);
            }
           static void Main(string[] args)
            {

            Calculation calc = new Calculation();
                calc.add(10, 12);
                calc.sub(15, 5);
            }
        }
    }
}
