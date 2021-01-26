﻿using System;
using System.Collections.Generic;
using System.Text;
using Canada.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<City>().Property(m => m.ProvinceCode).IsRequired();

            builder.Entity<Province>().Property(p => p.ProvinceCode).HasMaxLength(3);

            builder.Entity<Province>().ToTable("Province");
            builder.Entity<City>().ToTable("City");

            builder.Seed();

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
