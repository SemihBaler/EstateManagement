using System;
using System.Collections.Generic;

namespace Deneme.Models;

public partial class EstateType
{
    public int EstateTypeId { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Estate> Estates { get; set; } = new List<Estate>();
}
