using ConsoleApp2.model;
using ConsoleApp2.model.Context;

namespace Efcore 
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new info())
            {
                var std = new Student()
                {
                    StudName = "Pankaj"
                };
                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}

