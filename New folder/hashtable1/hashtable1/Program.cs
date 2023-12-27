using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();

            // add items to hashtable
            myTable.Add("Name", "Pankaj");
            myTable.Add("RollNumber", 12);
            myTable.Add("Address", "Shirdi");

            foreach (DictionaryEntry value in myTable)
        {
            Console.WriteLine("{0} : {1} ", value.Key, value.Value);
        }


            // print value of the element whose key is "RollNumber"
            Console.WriteLine(myTable["RollNumber"]);


            // Add elements in table
            Console.WriteLine("After Adding Element");
            myTable.Add("Subject", "Math");
            myTable.Add("Code", 139);
            foreach (DictionaryEntry value in myTable)
            {
                Console.WriteLine("{0} : {1} ", value.Key, value.Value);
            }

            // Delete Element in table
            Console.WriteLine("After removing Element");
            myTable.Remove("Name");

            Console.WriteLine("\n Modified Hashtable :");

           // iterate through the modified hashtable
            foreach (DictionaryEntry item in myTable)
            {
                Console.WriteLine("{0} : {1} ", item.Key, item.Value);
            }

        }
    }
}
