using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.SeedData
{
    public class EstateTypeSeedData : IEntityTypeConfiguration<EstateType>
    {
        public void Configure(EntityTypeBuilder<EstateType> builder)
        {
            builder.HasData(
                new EstateType { EstateTypeId=1,Name="Müstakil"},
                new EstateType { EstateTypeId=2,Name="Daire"},
                new EstateType { EstateTypeId=3,Name="Arsa"}
                );
        }
    }
}
