using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class SaglikKayitlari
{
    public int Id { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public string Teshis { get; set; } = null!;

    public string? Tedavi { get; set; }

    public string? Notlar { get; set; }

    public string? VeterinerAd { get; set; }

    public int HayvanId { get; set; }

    public virtual Hayvanlar Hayvan { get; set; } = null!;
}
