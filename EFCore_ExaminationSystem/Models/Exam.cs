using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public Result Result { get; set; }

        public List<UserExam> UserExams = new List<UserExam>();
        public List<Question> Questions { get; set; } = new List<Question>();

        public override string ToString()
        {
            return $"{Id} {Title} {Date}";
        }
    }
}
