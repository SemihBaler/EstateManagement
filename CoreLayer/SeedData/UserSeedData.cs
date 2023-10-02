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
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
              new User { UserId = 1, Name="Ahmet",Role="User"},
              new User { UserId = 2, Name="Mehmet",Role="Customer"},
              new User { UserId = 3, Name="Yade",Role="Admin"}
              );
        }
    }
}
