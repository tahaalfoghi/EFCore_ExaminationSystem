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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
           builder.ToTable(nameof(Answer));
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.Property(x => x.IsCorrect).IsRequired();

            builder.Property(x=>x.Text)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255).IsRequired();

            
        }
    }
}
