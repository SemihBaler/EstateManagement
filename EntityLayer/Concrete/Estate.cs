using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string? City { get; set; }
        public string? District { get; set; }
        public Type Type { get; set; }
        public int TypeId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
