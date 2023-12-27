using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program : User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program p = new Program();
            // Compiler Error
            // protected members can only be accessible with derived classes
            
            p.Name = "Pankaj Malik";
            p.Location = "Mumbai";
            p.Age = 24;
            p.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
