using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Estate : BaseEntity
    {
        [Key]
        public int EstateId { get; set; }
        public int? Price { get; set; }
        public string? Adress { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public EstateType EstateType { get; set; }
        public int EstateTypeId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
