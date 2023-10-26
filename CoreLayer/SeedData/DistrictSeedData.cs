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
    public class DistrictSeedData : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasData(
               new District { DistrictId = 1, Name = "Seyhan", CityId = 1 },
               new District { DistrictId = 2, Name = "Ceyhan", CityId = 1 }
               );
        }
    }
}
