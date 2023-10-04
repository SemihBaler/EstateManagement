using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos.CustomerDtos
{
    public class AddCustomerDto
    {

        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public int? Budget { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }

    }
}
