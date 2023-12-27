using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Operators.Employee;

namespace Operators
{
    public class Employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string Designation { get; set; }
        public string departmentname { get; set; }

        public class student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)
        {
            IList<Employee> emp1 = new List<Employee>()
            {
                new Employee() { empid = 1, name = "Pankaj",age= 30, Designation ="Software Devloer", departmentname ="Hr Dept"},
                new Employee() { empid = 2, name = "Sagar", age= 30, Designation = "Tranie",departmentname="web devlopement Department"},
                new Employee() { empid = 3, name = "Pratik", age=20, Designation = "Tester",departmentname="Testing Dept" },
                new Employee() { empid = 4, name = "Mayur", age = 20 ,Designation ="Software Devloer", departmentname ="Hr Dept"},
                new Employee() { empid = 5, name = "Pawan" , age=26,Designation = "Tranie",departmentname="web devlopement Department"},
                new Employee() { empid = 5, name = "Pawan" , age=26,Designation = "Tranie",departmentname="web devlopement Department"},
                new Employee() { empid = 3, name = "Mayuresh", age=15, Designation = "Tester",departmentname="Testing Dept" }
            };




            //Query Syntax
            //Where Clause
            
            Console.WriteLine("...........WHERE OPERATOR.............");
            Console.WriteLine("...........BY QUERY SYNTAX.............");
            var emp = from s in emp1 where s.age > 12 select s;
            Console.WriteLine("employee Age Greater than 12");

            foreach (Employee std in emp)
            {
                Console.WriteLine($"{std.empid}");
            }


            //Method Syntax
            Console.WriteLine("...........BY METHOD SYNTAX.............");
            var abc = emp1.Where(s => s.age>12 );
            foreach (Employee std in abc)
            {
                Console.WriteLine(std.empid);
            }

            //Printing name of Employee where Designation Software Devloper
            var kbc = emp1.Where(k => k.Designation.Contains("Software Devloer"));
            foreach(Employee obj in kbc)
            {
                Console.WriteLine(obj.name);
            }

            //OfType Operator
            Console.WriteLine("...........OfType OPERATOR.............");
            Console.WriteLine("...........BY PASSING EMPLOYEE.........");
            
           var pk = from s in emp1.OfType<Employee>() select s;
           foreach (Employee obj in pk)
           {
               Console.WriteLine(obj.Designation);
           }

           IList list = new ArrayList();
           list.Add("sanjay");
           list.Add("Kopargaon");
           list.Add(4);
           list.Add(3);

            Console.WriteLine("...........BY PASSING STRING.........");
            var dk = from s in list.OfType<string>() select s;

           foreach(var obj in dk)
           {
              Console.WriteLine(obj);
           }

            Console.WriteLine("...........BY PASSING INTEGER.........");
            var MK = from s in list.OfType<int>() select s;
            foreach(var ob in MK)
            {
                Console.WriteLine(ob);
            }


            //Order By
            Console.WriteLine(".........ORDERBY AESC..................");
            var orderbyresult = from s in emp1.OrderBy(s => s.age) select s;
            foreach(var std in orderbyresult)
            {
                Console.WriteLine( std.age);
            }

            var OrderByResult = from s in emp1.OrderBy(s=> s.name) select s;
            foreach(var std in OrderByResult)
            {
                Console.WriteLine( std.name);
            }

            Console.WriteLine(".........ORDERBY DESC..................");
            var ordBy = from k in emp1.OrderByDescending(k => k.age) select k;
            foreach(var std in ordBy)
            {
                Console.WriteLine(std.age);
            }
             var OrdBy = from s in emp1.OrderByDescending(s=> s.name) select s;
            foreach(var std in OrdBy)
            {
                Console.WriteLine(std.name); 
            }


            //Then By
            Console.WriteLine("...............THEN BY.....................");
            Console.WriteLine(".........ASCENDING ORDER..................");
            var a = emp1.OrderBy(s=> s.name).ThenBy(s => s.age).ThenBy(s=>s.departmentname);
            foreach(var order in a)
            {
                Console.WriteLine("Name :{0},\t\t Age :{1}, \t department Name :{2}" ,order.name,order.age,order.departmentname);
            }

            Console.WriteLine(".........DESCENDING ORDER..................");
            var desc = emp1.OrderByDescending(s => s.name).ThenBy(s => s.age).ThenBy(s => s.departmentname);
            foreach(var std in desc)
            {
                Console.WriteLine("Name :{0},\t\t Age :{1}, \t departmrnt Name :{2}", std.name, std.age, std.departmentname);
            }
           
            IList<student> stud = new List<student>();
            {
                new student() { id = 1, name = "Pankaj", age = 20 };
                new student() { id = 2, name = "Pawan", age = 20 };
                new student() { id = 3, name = "Pratik", age = 22 };
                new student() { id = 4, name = "mayur", age = 20 };
                new student() { id = 5, name = "sandy", age = 22 };
                new student() { id = 6, name = "rahul", age = 20 };
                new student() { id = 7, name = "nanavare", age = 23 };
            };

            Console.WriteLine(".........GROUP BY..................");
            //GroupBY
           // var groupresult = from s in emp1.GroupBy(s => s.age) select s;
            var groupedResult = emp1.GroupBy(s => s.age);

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Group ID :" + ageGroup.Key);  

                foreach (Employee s in ageGroup)  
                    Console.WriteLine("Student Name :" +s.name);
            }
            
            //TolookupBY
            Console.WriteLine(".............tOlOOKUP......................");
            var tolookup = emp1.ToLookup(s => s.age);
            foreach(var group in tolookup)
            {
                Console.WriteLine("Group ID :" + group.Key);

                foreach(Employee s in group)
                    Console.WriteLine("Student Name :" +s.name);
            }

            Console.WriteLine("................Average......................");
            var avgAge = emp1.Average(s => s.age);
           
                Console.WriteLine("Average Age of Student: {0}", avgAge);

            

            Console.WriteLine("......................AGGREGATE.....................");
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(commaSeperatedString);


            Console.WriteLine("......................Count.....................");
            IList<int> ints = new List<int>()
            { 10,15,25,20,22,35,40};

            var totalelements = ints.Count();
            Console.WriteLine("Total no of Elements : "+totalelements);

            var evenelements = ints.Count(i => i % 2 == 0);
            Console.WriteLine("Total no of Even Elements : " + evenelements);

            Console.WriteLine("......................Maximum.....................");
            var largest = ints.Max();
            Console.WriteLine("Largest No :" + largest);

          
            var largestEvenElements = ints.Max(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });
            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);
        }
       
        

        


    }
}
