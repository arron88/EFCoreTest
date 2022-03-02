using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace ScaffloldTest
{
    public partial class demo1Context : DbContext
    {
        //private static ILoggerFactory loggerFactory = LoggerFactory.Create(b=>b.AddConsole());
        public demo1Context()
        {
        }

        public demo1Context(DbContextOptions<demo1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dog> Dogs { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Person> Persons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = .\\SQLExpress ; Integrated Security = true ; Initial Catalog = demo1");
                //optionsBuilder.UseLoggerFactory(loggerFactory);//标准日志 正式使用依赖注入logging
                //optionsBuilder.LogTo(Console.WriteLine);//简单日志
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Dog");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("T_Books");

                entity.HasIndex(e => e.Name, "IX_T_Books_Name")
                    .IsUnique()
                    .HasFilter("([Name] IS NOT NULL)");

                entity.Property(e => e.Age111).HasColumnName("age111");

                entity.Property(e => e.Age2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('10')");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("T_Persons");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
