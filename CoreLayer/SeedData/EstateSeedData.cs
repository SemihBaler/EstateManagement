﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.SeedData
{
    public class EstateSeedData : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {
            builder.HasData(
                new Estate { EstateId=1,Price = 7500000,Adress="Bağlıca",CategoryId=1,City="Ankara",District="Etimesgut",EstateTypeId=2 },
                new Estate { EstateId=2,Price = 12000000,Adress="Alacaatlı",CategoryId=1,City="Ankara",District="Çankaya",EstateTypeId=3 },
                new Estate { EstateId=3,Price = 6500,Adress="Burhaniye",CategoryId=2,City="Balıkesir",District="Susurluk",EstateTypeId=1 },
                new Estate { EstateId=4,Price = 1500000,Adress="Elvan",CategoryId=1,City="İzmir",District="merkez",EstateTypeId=1 }
                );
        }
    }
}