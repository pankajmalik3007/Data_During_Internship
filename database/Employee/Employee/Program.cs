using Employee;
using Employee.Model;

namespace efcore
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            using(var context = new Info())
            {
                var std = new Employee12()
                {
                    Name = "Pankaj"
                };

                var std1 = new Employee12()
                {
                    Name = "Pratik"
                };

                var std2 = new Employee12()
                {
                    Name = "Mayur"
                };

                //Remove Elements
                //var std4 = context.Employees.First<Employee12>();
                //context.Employees.Remove(std4);
                //context.SaveChanges();

                //Update
                //var std3 = context.Employees.First<Employee12>();
                //std3.Name = "Sagar";
                //context.SaveChanges();

                var pk = context.Employees.Where(s=> s.Id==7).FirstOrDefault();
                pk.Name = "Samir";
                context.SaveChanges();
              

                context.Employees.Add(std);
                context.Employees.Add(std1);
                context.Employees.Add(std2);
                context.SaveChanges();
            }
        }
    }

}
