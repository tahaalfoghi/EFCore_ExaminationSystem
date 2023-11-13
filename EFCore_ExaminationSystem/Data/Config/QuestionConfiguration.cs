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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.Property(x=>x.Text)
                .HasColumnType("VARCHAR")
                .HasMaxLength(250).IsRequired();

            builder.HasOne(x => x.Answer)
                .WithOne(x => x.Question)
                .HasForeignKey<Answer>(x => x.QuestionId);
        }
    }
}
