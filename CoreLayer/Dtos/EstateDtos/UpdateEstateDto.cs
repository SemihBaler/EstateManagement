using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos.EstateDtos
{
    public class UpdateEstateDto
    {
        public int EstateId { get; set; }
        public int? Price { get; set; }
        public string? Adress { get; set; }
        public int CityId { get; set; }
        public int EstateTypeId { get; set; }
        public int CategoryId { get; set; }
    }
}
