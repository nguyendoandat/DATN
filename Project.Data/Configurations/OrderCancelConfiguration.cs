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
    public class OrderCancelConfiguration : IEntityTypeConfiguration<OrderCancel>
    {
        public void Configure(EntityTypeBuilder<OrderCancel> builder)
        {
            builder.ToTable("OrderCancels");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
           
        }
    }
}
