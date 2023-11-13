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
    public class UserExamConfiguration : IEntityTypeConfiguration<UserExam>
    {
        public void Configure(EntityTypeBuilder<UserExam> builder)
        {
            builder.ToTable("UserExam");
            builder.HasKey(x => new { x.UserId, x.ExamId });

        }
    }
}
