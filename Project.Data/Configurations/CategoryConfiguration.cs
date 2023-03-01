using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.HasIndex(x => x.CategoryName).IsUnique();
            //builder.HasIndex(x => x.Slug).IsUnique();
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            //builder.Property(x => x.Slug).IsRequired().HasMaxLength(255).HasColumnType("nvarchar");
            //builder.HasOne(x => x.User).WithMany(x => x.Shops).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
