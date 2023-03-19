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
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.HasOne(x=>x.Product).WithMany(x=>x.Carts).HasForeignKey(x=>x.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x=>x.User).WithMany(x=>x.Carts).HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
