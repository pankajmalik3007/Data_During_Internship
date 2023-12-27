using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> LapiNames = new Dictionary<int, string>();
            LapiNames.Add(1, "Dell"); //adding a key/value using the Add() method
            LapiNames.Add(2, "hp");
            LapiNames.Add(3, "Apple");

            foreach (KeyValuePair<int, string> kvp in LapiNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>()
            {
            {"dell", "8 GB Ram, black, 55000"},
             {"hp", "8 GB Ram, black, 55000"}
            };

                foreach (var Lapi in cities)
                Console.WriteLine("Key: {0}, Value: {1}", Lapi.Key, Lapi.Value);
        
        }
    }
}
