using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class BookConfig : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.ToTable("T_Books");
            builder.Property(b=>b.Name).HasMaxLength(50);
            builder.Property(b => b.Age).HasColumnName("age111");
            builder.Property(b => b.Age2).HasColumnType("varchar(100)");
            builder.Property(b => b.Age2).HasDefaultValue("10");
        }
    }
}
