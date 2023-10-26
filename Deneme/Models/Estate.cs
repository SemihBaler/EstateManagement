using System;
using System.Collections.Generic;

namespace Deneme.Models;

public partial class Estate
{
    public int EstateId { get; set; }

    public int? Price { get; set; }

    public string? Adress { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public int EstateTypeId { get; set; }

    public int CategoryId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int Status { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual EstateType EstateType { get; set; } = null!;
}
