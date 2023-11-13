using EFCore_ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Data
{
    // Sigleton Pattern
    public class DataLoader
    {
        private DataLoader() { }
        private static DataLoader? _instance;
        private static object? _lock = new();

        public static DataLoader Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new DataLoader();
                }
                return _instance;
            }
        }
        public List<Course> LoadCourses()
        {
            return new List<Course>
            {
                new Course { Id = 1, CourseName = "Mathematics" },
                new Course { Id = 2, CourseName = "English Literature" },
                new Course { Id = 3, CourseName = "Physics" },
                new Course { Id = 4, CourseName = "Chemistry" },
                new Course { Id = 5, CourseName = "Biology" },
                new Course { Id = 6, CourseName = "History" },
                new Course { Id = 7, CourseName = "Geography" },
                new Course { Id = 8, CourseName = "Computer Science" },
                new Course { Id = 9, CourseName = "Art" },
                new Course { Id = 10, CourseName = "Music" },
                new Course { Id = 11, CourseName = "Physical Education" },
                new Course { Id = 12, CourseName = "Economics" },
                new Course { Id = 13, CourseName = "Psychology" },
                new Course { Id = 14, CourseName = "Sociology" },
                new Course { Id = 15, CourseName = "Foreign Language" },
                new Course { Id = 16, CourseName = "Business Studies" },
                new Course { Id = 17, CourseName = "Political Science" },
                new Course { Id = 18, CourseName = "Philosophy" },
                new Course { Id = 19, CourseName = "Environmental Science" },
                new Course { Id = 20, CourseName = "Anthropology" },
            };
        }
        public List<User> LoadUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
                new User { Id = 3, Name = "Michael Johnson", Email = "michael.johnson@example.com" },
                new User { Id = 4, Name = "Emily Davis", Email = "emily.davis@example.com" },
                new User { Id = 5, Name = "Daniel Wilson", Email = "daniel.wilson@example.com" },
                new User { Id = 6, Name = "Olivia Taylor", Email = "olivia.taylor@example.com" },
                new User { Id = 7, Name = "Matthew Anderson", Email = "matthew.anderson@example.com" },
                new User { Id = 8, Name = "Sophia Martinez", Email = "sophia.martinez@example.com" },
                new User { Id = 9, Name = "Andrew Thompson", Email = "andrew.thompson@example.com" },
                new User { Id = 10, Name = "Emma Garcia", Email = "emma.garcia@example.com" },
                new User { Id = 11, Name = "William Robinson", Email = "william.robinson@example.com" },
                new User { Id = 12, Name = "Ava Lewis", Email = "ava.lewis@example.com" },
                new User { Id = 13, Name = "James Lee", Email = "james.lee@example.com" },
                new User { Id = 14, Name = "Isabella Walker", Email = "isabella.walker@example.com" },
                new User { Id = 15, Name = "Benjamin Hall", Email = "benjamin.hall@example.com" },
                new User { Id = 16, Name = "Mia Green", Email = "mia.green@example.com" },
                new User { Id = 17, Name = "Henry Adams", Email = "henry.adams@example.com" },
                new User { Id = 18, Name = "Charlotte Hill", Email = "charlotte.hill@example.com" },
                new User { Id = 19, Name = "Joseph Baker", Email = "joseph.baker@example.com" },
                new User { Id = 20, Name = "Amelia Campbell", Email = "amelia.campbell@example.com" }
            };
        }
        public List<Exam> LoadExams()
        {
            return new List<Exam>
            {
                new Exam { Id = 1, Title = "Math Exam 1", CourseId = 1,             Date = new DateTime(2023, 1, 10) },
                new Exam { Id = 2, Title = "English Exam 1", CourseId = 2,          Date = new DateTime(2023, 2, 15) },
                new Exam { Id = 3, Title = "Physics Exam 1", CourseId = 3,          Date = new DateTime(2023, 3, 20) },
                new Exam { Id = 4, Title = "Chemistry Exam 1", CourseId = 4,        Date = new DateTime(2023, 4, 25) },
                new Exam { Id = 5, Title = "Biology Exam 1", CourseId = 5,          Date = new DateTime(2023, 5, 30) },
                new Exam { Id = 6, Title = "History Exam 1", CourseId = 6,          Date = new DateTime(2023, 6, 5) },
                new Exam { Id = 7, Title = "Geography Exam 1", CourseId = 7,        Date = new DateTime(2023, 7, 10) },
                new Exam { Id = 8, Title = "Computer Science Exam 1", CourseId = 8, Date = new DateTime(2023, 8, 15) },
                new Exam { Id = 9, Title = "Art Exam 1", CourseId = 9,        Date = new DateTime(2023, 9, 20) },
                new Exam { Id = 10, Title = "Music Exam 1", CourseId = 10, Date = new DateTime(2023, 10, 25) },
                new Exam { Id = 11, Title = "Physical Education Exam 1", CourseId = 11, Date = new DateTime(2023, 11, 30) },
                new Exam { Id = 12, Title = "Economics Exam 1", CourseId = 12, Date = new DateTime(2023, 12, 5) },
                new Exam { Id = 13, Title = "Psychology Exam 1", CourseId = 13, Date = new DateTime(2024, 1, 10) },
                new Exam { Id = 14, Title = "Sociology Exam 1", CourseId = 14, Date = new DateTime(2024, 2, 15) },
                new Exam { Id = 15, Title = "Foreign Language Exam 1", CourseId = 15, Date = new DateTime(2024, 3, 20) },
                new Exam { Id = 16, Title = "Business Studies Exam 1", CourseId = 16, Date = new DateTime(2024, 4, 25) },
                new Exam { Id = 17, Title = "Political Science Exam 1", CourseId = 17, Date = new DateTime(2024, 5, 30) },
                new Exam { Id = 18, Title = "Philosophy Exam 1", CourseId = 18, Date = new DateTime(2024, 6, 5) },
                new Exam { Id = 19, Title = "Environmental Science Exam 1", CourseId = 19, Date = new DateTime(2024, 7, 10) },
                new Exam { Id = 20, Title = "Anthropology Exam 1", CourseId = 20, Date = new DateTime(2024, 8, 15) }
            };
        }
        public List<Question> LoadQuestions()
        {
            return new List<Question>
            {
                new Question { Id = 1,  ExamId = 1,  Text = "What is the sum of 2 + 2?" },
                new Question { Id = 2,  ExamId = 1,  Text = "Who is the author of Romeo and Juliet?" },
                new Question { Id = 3,  ExamId = 1,  Text = "What is the capital of France?" },
                new Question { Id = 4,  ExamId = 1,  Text = "What is the chemical symbol for gold?" },
                new Question { Id = 5,  ExamId = 1,  Text = "Who painted the Mona Lisa?" },
                new Question { Id = 6,  ExamId = 1,  Text = "What is the largest planet in our solar system?" },
                new Question { Id = 7,  ExamId = 1,  Text = "What is the square root of 64?" },
                new Question { Id = 8,  ExamId = 1,  Text = "Who wrote the play Macbeth?" },
                new Question { Id = 9,  ExamId = 1,  Text = "What is the chemical formula for water?" },
                new Question { Id = 10, ExamId = 1, Text = "What is the capital of Japan?" },
                new Question { Id = 11, ExamId = 1, Text = "What is the symbol for the element hydrogen?" },
                new Question { Id = 12, ExamId = 1, Text = "Who is the artist behind the painting The Starry Night?" },
                new Question { Id = 13, ExamId = 1, Text = "What is the largest ocean on Earth?" },
                new Question { Id = 14, ExamId = 1, Text = "What is the result of 5 multiplied by 7?" },
                new Question { Id = 15, ExamId = 1, Text = "Who is the author of To Kill a Mockingbird?" },
                new Question { Id = 16, ExamId = 1, Text = "What is the capital of Australia?" },
                new Question { Id = 17, ExamId = 1, Text = "What is the chemical symbol for oxygen?" },
                new Question { Id = 18, ExamId = 1, Text = "Who painted the Last Supper?" },
                new Question { Id = 19, ExamId = 1, Text = "What is the smallest planet in our solar system?" },
                new Question { Id = 20, ExamId = 1, Text = "What is the result of 8 divided by 2?" }
            };
        }
        public List<Answer> LoadAnswers()
        {
            return new List<Answer>
            {
                new Answer { Id = 1, QuestionId = 1, Text = "4", IsCorrect=true },
                new Answer { Id = 2, QuestionId = 2, Text = "5" ,IsCorrect=true},
                new Answer { Id = 3, QuestionId = 3, Text = "6" ,IsCorrect=true},
                new Answer { Id = 4, QuestionId = 4, Text = "8" ,IsCorrect=true},
                new Answer { Id = 5, QuestionId = 5, Text = "William Shakespeare",IsCorrect=true },
                new Answer { Id = 6, QuestionId = 6, Text = "Charles Dickens" , IsCorrect = false},
                new Answer { Id = 7, QuestionId = 7, Text = "Jane Austen" , IsCorrect = true},
                new Answer { Id = 8, QuestionId = 8, Text = "Mark Twain" , IsCorrect = true},
                new Answer { Id = 9, QuestionId = 10, Text = "Paris" , IsCorrect = true},
                new Answer { Id = 10, QuestionId = 9, Text = "London" , IsCorrect = false},
                new Answer { Id = 11, QuestionId = 12, Text = "Rome" , IsCorrect = true},
                new Answer { Id = 12, QuestionId = 11, Text = "Tokyo" , IsCorrect = true},
                new Answer { Id = 13, QuestionId = 14, Text = "Au" , IsCorrect = true},
                new Answer { Id = 14, QuestionId = 13, Text = "Ag" , IsCorrect = false},
                new Answer { Id = 15, QuestionId = 15, Text = "Cu" , IsCorrect = false},
                new Answer { Id = 16, QuestionId = 16, Text = "Pb" , IsCorrect = true},
                new Answer { Id = 17, QuestionId = 17, Text = "Leonardo da Vinci" , IsCorrect = true},
                new Answer { Id = 18, QuestionId = 19, Text = "Pablo Picasso" , IsCorrect = true},
                new Answer { Id = 19, QuestionId = 20, Text = "Vincent van Gogh" , IsCorrect = true},
                new Answer { Id = 20, QuestionId = 18, Text = "Michelangelo" , IsCorrect = false}
            };
        }
        public List<Result> LoadResults()
        {
            // Specify the ExamId for which you want to load results

            List<Result> results = new List<Result>();

            for (int i = 1; i <= 20; i++)
            {
                results.Add(new Result { Id = i, UserId = i, ExamId = i, Score = 60 + i + 5 - (10) });
            }

            return results;
        }
        public List<UserExam> LoadUserExams()
        {
            return new List<UserExam>
            {
                 new UserExam {ExamId=1, UserId=1,  Date=new DateTime(2023, 1, 10)},
                 new UserExam {ExamId=1, UserId=2,  Date=new DateTime(2023, 2, 15)},
                 new UserExam {ExamId=1, UserId=3,  Date=new DateTime(2023, 3, 20)},
                 new UserExam {ExamId=1, UserId=4,  Date=new DateTime(2023, 4, 25)},
                 new UserExam {ExamId=1, UserId=5,  Date=new DateTime(2023, 5, 30)},
                 new UserExam {ExamId=1, UserId=6,  Date=new DateTime(2023, 6, 5)},
                 new UserExam {ExamId=1, UserId=7,  Date=new DateTime(2023, 7, 10)},
                 new UserExam {ExamId=1, UserId=8,  Date=new DateTime(2023, 8, 15)},
                 new UserExam {ExamId=1, UserId=9,  Date=new DateTime(2023,9,12)},
                 new UserExam {ExamId=1, UserId=10, Date=new DateTime(2023,8,11)},
                 new UserExam {ExamId=1, UserId=11, Date=new DateTime(2023,8,3)},
                 new UserExam {ExamId=1, UserId=12, Date=new DateTime(2023,3,2)},
                 new UserExam {ExamId=1, UserId=13, Date=new DateTime(2023,8,23)},
                 new UserExam {ExamId=1, UserId=14, Date=new DateTime(2023,10,11)},
                 new UserExam {ExamId=1, UserId=15, Date=new DateTime(2023,10,4)},
                 new UserExam {ExamId=1, UserId=16, Date=new DateTime(2023,10,5)},
                 new UserExam {ExamId=1, UserId=17, Date=new DateTime(2023,12,4)},
                 new UserExam {ExamId=1, UserId=18, Date=new DateTime(2023,11,3)},
                 new UserExam {ExamId=1, UserId=19, Date=new DateTime(2023,9,19)},
                 new UserExam {ExamId=1, UserId=20, Date=new DateTime(2023,9,23)},
            };
        }
    }
}
