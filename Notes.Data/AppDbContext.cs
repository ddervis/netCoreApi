using Microsoft.EntityFrameworkCore;
using Notes.Core.Models;
using Notes.Data.Configuration;
using Notes.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }


        public DbSet<Note> MyProperty { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Target> Target { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NoteConfiguration());
            modelBuilder.ApplyConfiguration(new TargetConfiguration());

            modelBuilder.ApplyConfiguration(new NoteSeed(new int[] { 1,2}));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
        }

    }
}
