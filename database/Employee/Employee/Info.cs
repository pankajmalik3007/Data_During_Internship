using Employee.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Info:DbContext
    {
        public DbSet<Employee12> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=TGS148\SQLEXPRESS;Initial Catalog=EmpData;Integrated Security=True; Encrypt = True; TrustServerCertificate = True;");
        }
    }
    
}
