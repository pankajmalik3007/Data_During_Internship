using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListColle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oddnum = new List<int>();
            oddnum.Add(1);
            oddnum.Add(3);
            oddnum.Add(5);
            oddnum.Add(7);
           // oddnum.Add(8);
            Console.WriteLine("Number Of Elements - "+ oddnum.Count);
            for (int i = 0;i<oddnum.Count;i++)
            {
                Console.WriteLine(oddnum[i]);
            }
         


            // adding elements using collection initializer syntax
            var Fullname = new List<string>() { "My", "Name", "is", "Pankaj" };

            Console.WriteLine("Number of Elements -"+Fullname.Count);


            //Adding Element in a list

            Console.WriteLine("After Adding an Element ");
            oddnum.Add(8);
            Console.WriteLine("Number Of Elements - " + oddnum.Count);
            for (int i = 0; i < oddnum.Count; i++)
            {
                Console.WriteLine(oddnum[i]);
            }


            // delete
            Console.WriteLine("After Removing an Element ");
            oddnum.Remove(5);
            Console.WriteLine("Number Of Elements - " + oddnum.Count);
            for (int i = 0; i < oddnum.Count; i++)
            {
                Console.WriteLine(oddnum[i]);
            }


            //Updating

            Console.WriteLine("After Updating Element ");
            oddnum[3] = 10;
            Console.WriteLine("Number Of Elements - " + oddnum.Count);
            for (int i = 0; i < oddnum.Count; i++)
            {
                Console.WriteLine(oddnum[i]);
            }
        }
    }
}
