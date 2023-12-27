using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
     class Program
    {
        public string Name;
        public int Age;
        public void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
        }



        static void Main(string[] args)
        {
            Program u = new Program();
            u.Name = "Pankaj Malik";
            u.Age = 32;
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
