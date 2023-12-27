using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class Program
    {    //ONE INTERFACE WITH 3 METHODS
        interface IInterface
        {
            void Stud(String name);

            void Addition();

            void expon();
        }

        public class Name : IInterface
        {
            public void Stud(String name)
            {
                string n = name;
                Console.WriteLine(n);
            }

            public void Addition()
            {
                int a = 2;
                int b = 3;
                int c = a + b;
                Console.WriteLine(c);

            }
            public void expon()
            {
                int bn = 5, expo = 4, power = 1, i = 1;
                while (i <= expo)
                {
                    power = power * bn;
                    i++;
                }
                Console.Write("Power : " + power);

                Console.ReadLine();
            }
        }


         static void Main(string[] args)
        {

            int num = 9;
            bool isEven;

            // TO CREATE A METHOD TO CHECK BOTH CONDITION ARE TRUE OR FALSE
            //First Way
            isEven = (num % 2 == 0) ? true : false;
            Console.WriteLine("The Given No is - "+isEven);



            //Second Way

            Console.WriteLine((num % 2 == 0) ?  true : false);

            Name na = new Name();
            na.Stud("Pankaj");
            na.Addition();
            na.expon();

        }
    }
}

