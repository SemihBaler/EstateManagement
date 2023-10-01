using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EstateType : BaseEntity
    {
        [Key]
        public int EstateTypeId { get; set; }
        public string? Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Estate> Estates { get; set; }

       
    }
}
