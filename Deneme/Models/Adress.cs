using System;
using System.Collections.Generic;

namespace Deneme.Models;

public partial class Adress
{
    public int Id { get; set; }

    public string? SehirIlceMahalleAdi { get; set; }

    public int? UstId { get; set; }

    public string? Minlongitude { get; set; }

    public string? Minlatitude { get; set; }

    public string? Maxlongitude { get; set; }

    public string? Maxlatitude { get; set; }

    public string? MahalleId { get; set; }
}
