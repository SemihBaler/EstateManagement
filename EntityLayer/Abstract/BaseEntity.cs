using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public enum Status { Active = 1, Passive, Modified }
    public abstract class BaseEntity
    {

        private DateTime createdDate;
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        private Status status;
        public Status Status { get => status; set => status = value; }

    }
}
