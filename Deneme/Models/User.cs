using System;
using System.Collections.Generic;

namespace Deneme.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? Mail { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
