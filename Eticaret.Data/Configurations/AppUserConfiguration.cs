﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(x => x.Surname)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(x => x.Phone)
                .HasColumnType("varchar(15)")
                .HasMaxLength(50);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(x => x.UserName)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            //başlangıç verisi

            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    Name = "Test",
                    Surname = "User",            
                    Email = "admin@eticaret.io",                                      
                    Password = "123456*",
                    UserName = "Admin",
                    IsActive = true,
                    IsAdmin = true,
                });



        }
    }
}
