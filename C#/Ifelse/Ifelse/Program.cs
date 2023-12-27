using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    public class Program
    {
        public void Addition( ref int x )
        {
            x = 10;
           
            Console.WriteLine("Value inside the show Function"+ x);
        }
       public static void Main(string[] args)
        {
            /*
            int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is a Odd number");
            }


               2) C# If-else Example: with input from user
                In this example, we are getting input from the user using
                Console.ReadLine() method.It returns string.For numeric value,
                you need to convert it into int using Convert.ToInt32() method.



            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2== 0)
                {
                  Console.WriteLine("Its a Even No");
                }
            else
            {
                Console.WriteLine("Its a odd num");
            }

             C# IF-else-if ladder Statement
             The C# if-else-if ladder statement executes one condition from multiple statements.



            int x =50;
            if (x >= 80)
            {
                Console.WriteLine("True X is >= 50");
            }
            else if (x < 40)
            {
                Console.WriteLine("True X is < 50");
            }
            else
            {
                Console.WriteLine("The X is not Present");            
            }


            3) Marksheet


            Console.WriteLine("Enter Any Num");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <=0 || num > 100)
            {
                Console.WriteLine("Invalid number");
            }
            else if (num >= 0 && num <= 50)
            {
                Console.WriteLine("Fail");
            }

            else if (num >= 70 && num < 60)
            {
                Console.WriteLine("D Grade");
            }

            else if (num >= 80 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 90 && num < 80)
            {
                Console.WriteLine("B Grade");
            }

            else if (num >= 100 && num < 90)
            {
                Console.WriteLine("A Grade");
            }


            C# switch
            The C# switch statement executes one statement from multiple conditions. It is like if-else-if ladder statement in C#.

            Syntax:

            switch (expression)
            {
                case value1:
                    //code to be executed;    
                    break;
                case value2:
                    //code to be executed;    
                    break;
                    ......default:     
             //code to be executed if all cases are not matched;    
            break;
            }

            Example

            //repeat:
            Console.WriteLine("enter Any No");
            int num = Convert.ToInt32(Console.ReadLine());
            int add = 0;
            for (int i = 0; i<=num;i++)
            {
                 add = add + i;
            }
                 Console.WriteLine(add);
           // goto repeat;



            //SWITCH STATEMENT
            Console.WriteLine("Enter any no");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }



            //FOR LOOP

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //NESTED FOR LOOP

            for (int i = 1;i <= 10; i++)
            {
                for(int j =1; j <= 10; j++)
                {
                    Console.WriteLine(i+" "+j);
                }
            }

            //INFINITE FOR LOOP
            for (; ; )
            {
                Console.WriteLine("Infinitive For Loop");
            }


            //WHILE LOOP
            //In C#, while loop is used to iterate a part of the program several times. 
            //If the number of iteration is not fixed, it is recommended to use while loop than for loop.

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }


            // NESTED WHILE LOOP
            int i = 1;
            while (i <= 3)
            {
                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                }
                i++;
            }



            // DO WHILE LOOP
           // The C# do-while loop is executed at least once because condition is checked after loop body.
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            // NESTED DO WHILE

            int i = 1;

            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);



            //BREAK STATEMENTS

            //C# break statement which is used inside the loop.

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            //C# Break Statement with Inner Loop
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        break;
                    }
                    Console.WriteLine(i + " " + j);
                }
            }

            // CONTINUE STATEMENT
            //The C# continue statement is used to continue loop. 
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            // CONTINUE STATEMENTS WITH INNER LOOP
            // Continuos ststement continue only inner loop
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        continue;
                    }
                    Console.WriteLine(i + " " + j);
                }
            }




            //GOTO STATEMENT
            ineligible:
                Console.WriteLine("You are not eligible to vote!");

                Console.WriteLine("Enter your age:\n");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    goto ineligible;
                }
                else
                {
                    Console.WriteLine("You are eligible to vote!");
                }

     */

            //Functions 
            Program p = new Program();
            int x = 15;
            Console.WriteLine("value before Passing" + x);

            p.Addition(ref x);
            Console.WriteLine("Value After passing" + x);



           
        }

    }
    }
