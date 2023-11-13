using EFCore_ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ExaminationSystem.Data.Config
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exam");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();


            builder.Property(x=>x.Date).HasColumnType("Date").IsRequired();

            builder.HasOne(x=>x.Result)
                .WithOne(x=>x.Exam)
                .HasForeignKey<Result>(x=>x.ExamId).IsRequired();

            builder.HasMany(x => x.Questions)
                .WithOne(x => x.Exam)
                .HasForeignKey(x => x.ExamId).IsRequired();

            builder.HasMany(x => x.Users)
                .WithMany(x => x.Exams)
                .UsingEntity<UserExam>(
                 x => x.HasOne(x => x.User)
                 .WithMany(x => x.UserExams)
                 .HasForeignKey(x => x.UserId).IsRequired(),
                 x => x.HasOne(x => x.Exam)
                 .WithMany(x => x.UserExams)
                 .HasForeignKey(x => x.ExamId).IsRequired(),
                 x => x.Property(x => x.Date).HasColumnType("Date").IsRequired()
                );
        }
    }
}
