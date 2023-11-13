using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
        public override string ToString()
        {
            return $"{Id} {CourseName} {string.Join(" ",Exams)} ";
        }
    }
}
