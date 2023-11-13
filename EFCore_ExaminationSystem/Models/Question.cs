using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public string? Text { get; set; }
        public Answer Answer { get; set; }

    }
}
