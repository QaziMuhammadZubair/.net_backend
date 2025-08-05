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

    }
}
