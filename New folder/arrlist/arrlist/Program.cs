using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating An Array
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Pankaj");
            arlist1.Add("Malik ");
            arlist1.Add(false);
            arlist1.Add(null);

            
            //Printing an array
            Console.WriteLine("ArrayList 1 Elements");
                 for (int i = 0; i < arlist1.Count; i++)
                 Console.WriteLine(arlist1[i]);



            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
             { 2, "Pankaj", true, 4.5, null};

            Console.WriteLine("ArrayList 2 Elements");

                for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);


            //Inserting New Element in Array
            Console.WriteLine("After inserting new Element in Arry");
            arlist1.Insert(1, "Second Item");

                foreach (var val in arlist1)
                Console.WriteLine(val);


            //Removing  Element From Array
            Console.WriteLine("After Deleting new Element in Arry");
            arlist1.Remove(1);

                foreach (var val in arlist1)
                Console.WriteLine(val);

            //Updating element in Array 
            Console.WriteLine("After Updating an Element");
            arlist1[3]="value";

                foreach (var val in arlist1)
                Console.WriteLine(val);
        }
    }
    }

