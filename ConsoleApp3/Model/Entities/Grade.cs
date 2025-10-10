using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}