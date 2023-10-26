﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class District : BaseEntity
    {
        [Key]
        public int DistrictId { get; set; }
        public string? Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }

    }
}
