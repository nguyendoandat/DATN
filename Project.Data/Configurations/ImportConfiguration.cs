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
    public class ImportConfiguration : IEntityTypeConfiguration<Import>
    {
        public void Configure(EntityTypeBuilder<Import> builder)
        {
            builder.ToTable("Imports");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Address).IsRequired();
        }
    }
}
