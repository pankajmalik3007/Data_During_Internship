using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> Days = new Queue<String>();
            Days.Enqueue("Sun");
            Days.Enqueue("Mon");
            Days.Enqueue("tue");
            Days.Enqueue("wed");
            Days.Enqueue("thus");
            Days.Enqueue("fri");
            foreach (var Weekdays in Days )
             Console.WriteLine(Weekdays);


            // peek method
            if (Days.Count > 0)
            {
                Console.WriteLine(Days.Peek()); 
                Console.WriteLine(Days.Peek()); 
            }


            //Contains method
            Console.WriteLine("Check Element true or False ");
            Console.WriteLine(Days.Contains("thus"));


            //Dequeue Method
            Console.WriteLine("After Deleting element");
            while (Days.Count > 0)
                Console.WriteLine(Days.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", Days.Count);

        }
    }
}
