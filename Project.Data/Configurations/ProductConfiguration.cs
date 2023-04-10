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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(x => x.Slug).IsRequired().HasMaxLength(255).IsRequired();
            builder.Property(x => x.ProductDetail).IsRequired().HasColumnType("ntext");
            builder.Property(x => x.Price).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.View).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
           // builder.HasOne(x => x.Promotion).WithMany(x => x.Products).HasForeignKey(x => x.PromotionId).OnDelete(DeleteBehavior.Cascade);
           // builder.HasOne(x => x.ImportProduct).WithMany(x => x.Products).HasForeignKey(x => x.ImportProductId).OnDelete(DeleteBehavior.Cascade);
            //builder.HasOne(x => x.Import).WithMany(x => x.Products).HasForeignKey(x => x.ImportId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
