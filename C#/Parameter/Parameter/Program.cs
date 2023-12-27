using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    internal class Program
    {
          /*
           Passing Value Type Variables 

           When you pass a value - type variable from one method to another, the system creates a separate copy of a variable in another method.
            If value got changed in the one method, it wouldn't affect the variable in another method.
           */
        static void Multiplication(int a )
        {
            a = 2;
            Console.WriteLine(a);
        }
            
        
        
        //Pointer Type
        public string Name { get; set; }
        public static void clas(Program name)
        {
            name.Name = "Pankaj";
        }

    
    static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine(i);

            Multiplication(i);

            Console.WriteLine( " Change value of a is " +i);

           
            
            
            //pointer type

            Program name1 = new Program();
            name1.Name = "Malik";

            clas(name1);

            Console.WriteLine(name1.Name);

        }
    }
}
