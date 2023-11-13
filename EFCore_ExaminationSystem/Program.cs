using EFCore_ExaminationSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCore_ExaminationSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!await context.Courses.AnyAsync())
                {
                    await context.Courses.AddRangeAsync(DataLoader.Instance.LoadCourses());
                }
                if (!await context.Users.AnyAsync())
                {
                    await context.Users.AddRangeAsync(DataLoader.Instance.LoadUsers());
                }
                if (!await context.Exams.AnyAsync())
                {
                    await context.Exams.AddRangeAsync(DataLoader.Instance.LoadExams());
                }
                if (!await context.Questions.AnyAsync())
                {
                    await context.Questions.AddRangeAsync(DataLoader.Instance.LoadQuestions());
                }
                if (!await context.Answers.AnyAsync())
                {
                    await context.Answers.AddRangeAsync(DataLoader.Instance.LoadAnswers());
                }
                if (!await context.Results.AnyAsync())
                {
                    await context.Results.AddRangeAsync(DataLoader.Instance.LoadResults());
                }
                if (!await context.UserExams.AnyAsync())
                {
                    await context.UserExams.AddRangeAsync(DataLoader.Instance.LoadUserExams());
                }

                await context.SaveChangesAsync();
            }

                Console.ReadKey();
        }
    }
}