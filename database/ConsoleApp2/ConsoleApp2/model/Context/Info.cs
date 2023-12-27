using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.model.Context
{
    public class info : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Data Source=TGS148\SQLEXPRESS;Initial Catalog=SchoolDb1;Integrated Security=True;Encrypt=True; TrustServerCertificate=True;");
        }
    }
}
