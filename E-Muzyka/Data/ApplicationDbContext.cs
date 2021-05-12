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
                entity.Property(x => x.Title).HasMaxLength(20).IsRequired();
            });
            base.OnModelCreating(builder);
        }
    }
}