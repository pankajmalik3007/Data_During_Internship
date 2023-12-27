using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<String> Name = new Stack<String>();
            Name.Push("my");
            Name.Push("Name");
            Name.Push("Is");
            Name.Push("Pankaj");

            Console.WriteLine("Number Of Elements - " + Name.Count);
        
            foreach (var item in Name)
            {
                Console.WriteLine(item);
            }


            //Creating an Array of Stack
            Console.WriteLine("Creating Stack Using Array");
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> nos = new Stack<int>(arr);

            foreach (var itm in nos)
                Console.WriteLine(itm);


            //Contains Method used to define that element are present in stack or not.
            Console.WriteLine(Name.Contains("my"));
            Console.WriteLine(Name.Contains("PANKAJ"));

           
            
            //Peek Method
            if (Name.Count > 0)
            {
                Console.WriteLine(Name.Peek());

            }

            Console.WriteLine("After Delete Element");
            while (Name.Count > 0)
            Console.WriteLine(Name.Pop());
            Console.WriteLine("Number of elements in Stack: {0}", Name.Count);

       }
    }
}
