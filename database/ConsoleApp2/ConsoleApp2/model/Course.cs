using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.model
{
    public class Course
    {
       // [Keyless]
        public int Id { get; set; }
        public string Coursename { get; set; }
    }
}
