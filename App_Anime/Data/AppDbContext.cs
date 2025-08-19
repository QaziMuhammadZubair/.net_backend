using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_Anime.model;

namespace App_Anime.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<App_Anime.model.Anime> Anime { get; set; } = default!;
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Teachers)      // A Department has many Teachers
                .WithOne(t => t.Department)    // A Teacher has one Department
                .HasForeignKey(t => t.DepartmentId)
                 .OnDelete(DeleteBehavior.Cascade); // or Restrict, SetNull, etc.; // The foreign key is DepartmentId
        }

    }
}
