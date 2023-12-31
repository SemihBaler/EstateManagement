﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public enum Status { Active = 1, Modified, Passive  }
    public abstract class BaseEntity:IEntity
    {

        private DateTime createdDate= DateTime.Now;
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        private Status status=Status.Active;
        public Status Status { get => status; set => status = value; }

    }
}
