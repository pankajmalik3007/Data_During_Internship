using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.model
{
    [Keyless]
    public class Student
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
    }
}
