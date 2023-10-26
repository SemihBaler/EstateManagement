﻿using CoreLayer.DataAccess.EntityFramework.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class CityDal : EfBaseRepository<City, EstateDbContext>, ICityDal
    {
        public CityDal(EstateDbContext context) : base(context)
        {
        }
    }
}
