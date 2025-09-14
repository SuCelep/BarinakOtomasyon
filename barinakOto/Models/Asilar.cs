using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Asilar
{
    public int Id { get; set; }

    public string AsiAdi { get; set; } = null!;

    public DateTime AsiTarihi { get; set; }

    public DateTime? SonrakiAsiTarihi { get; set; }

    public string? VeterinerAd { get; set; }

    public int HayvanId { get; set; }

    public virtual Hayvanlar Hayvan { get; set; } = null!;
}
