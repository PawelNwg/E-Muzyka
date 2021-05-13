using E_Muzyka.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Muzyka.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Album>(entity =>
            {
                entity.Property(x => x.Title).HasMaxLength(30).IsRequired();
                entity.Property(x => x.Artist).HasMaxLength(30);
                entity.Property(x => x.Year).HasMaxLength(4);
                entity.Property(x => x.Version).HasMaxLength(20);
            });
            builder.Entity<Track>(entity =>
            {
                entity.Property(x => x.Title).HasMaxLength(30).IsRequired();
                entity.Property(x => x.Artist).HasMaxLength(30);
                entity.Property(x => x.Year).HasMaxLength(4);
            });
            builder.Entity<AppUser>(entity =>
            {
                entity.Property(x => x.Name).HasMaxLength(20);
                entity.Property(x => x.Surname).HasMaxLength(30);
            });
            base.OnModelCreating(builder);
        }
    }
}