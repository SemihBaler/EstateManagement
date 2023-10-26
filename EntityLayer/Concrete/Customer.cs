using EntityLayer.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer : BaseEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Budget { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public EstateType EstateType { get; set; }
        public int EstateTypeId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
