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
    public class MediasConfiguration : IEntityTypeConfiguration<Medias>
    {
        public void Configure(EntityTypeBuilder<Medias> builder)
        {
            builder.ToTable("Medias");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            //builder.HasOne(x => x.Product).WithMany(x => x.Medias).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
