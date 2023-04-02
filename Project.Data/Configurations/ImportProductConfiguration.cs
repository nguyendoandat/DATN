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
    public class ImportProductConfiguration : IEntityTypeConfiguration<ImportProduct>
    {
        public void Configure(EntityTypeBuilder<ImportProduct> builder)
        {
            builder.ToTable("ImportProducts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            builder.Property(x => x.Quantity).HasColumnType("integer").IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal").IsRequired();
            builder.HasOne(x=>x.Import).WithMany(x=>x.ImportProducts).HasForeignKey(x=>x.ImportId).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
