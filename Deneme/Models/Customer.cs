using System;
using System.Collections.Generic;

namespace Deneme.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? Mail { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Adress { get; set; }

    public int? Budget { get; set; }

    public int TypeId { get; set; }

    public int CategoryId { get; set; }

    public int? EstateTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int Status { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual EstateType? EstateType { get; set; }

    public virtual User Type { get; set; } = null!;
}
