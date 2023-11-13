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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(56).IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(56).IsRequired();

            builder.HasOne(x => x.Result)
                .WithOne(x => x.User)
                .HasForeignKey<Result>(x => x.UserId).IsRequired();
        }
    }
}
