using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.SeedData
{
    public class CustomerSeedData : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
              new Customer { CustomerId = 1, Name = "Semih", LastName = "Baler", Mail = "semihbaler@gmail.com", CityId = 1, Budget = 5000000, EstateTypeId = 2, CategoryId = 1 },
              new Customer { CustomerId = 2, Name = "Merve", LastName = "Baler", CityId = 1, Budget = 12000, EstateTypeId = 1, CategoryId = 2 }
              );
        }
    }
}
