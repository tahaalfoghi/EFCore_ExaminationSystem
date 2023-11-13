using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
        public Result Result { get; set; }
        public List<UserExam> UserExams = new List<UserExam>();
        public override string ToString()
        {
            return $"{Id} {Name} {Email}";
        }

    }
}
