using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10: Console.WriteLine("it is 10");break;
                case 20: Console.WriteLine("it is 20");break;
                default: Console.WriteLine("It is not a num");break;
            }
        }
    }
}
