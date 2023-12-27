using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQE1
{
    public class student
    {
        public int studid { get; set; }
        public int rollno { get; set; }
        public int age { get; set; }

        static void Main(string[] args)
        {

            IList<student> students = new List<student>();
            {
                new student() { studid = 1, rollno = 2, age = 18 };
                new student() { studid = 2, rollno = 33, age = 30 };
                new student() { studid = 3, rollno = 45, age = 36 };
                new student() { studid = 4, rollno = 22, age = 14 };
            };

            var teenAgerStudent = from s in students
                                  where s.age>10 && s.age<20 select s;

            Console.WriteLine("teenAgerStudent" );
            foreach(student teen in teenAgerStudent)
            {
                Console.WriteLine(teen.studid);

            }
        }
    }
}