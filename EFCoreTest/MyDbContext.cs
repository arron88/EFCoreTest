using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class MyDbContext:DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Dog> Dog { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = .\\SQLExpress ; Integrated Security = true ; Initial Catalog = demo1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            modelBuilder.Entity<Books>().Ignore(b => b.Age1);
            modelBuilder.Entity<Books>().HasIndex(b=>b.Name).IsUnique();
        }
    }
}
