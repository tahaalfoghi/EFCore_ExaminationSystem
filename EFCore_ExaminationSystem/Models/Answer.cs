using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string? Text { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
       
        public override string ToString()
        {
            return $"{Id} {QuestionId} {IsCorrect} {Text}";
        }
    }
}
