using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Barinaklar
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string? Adres { get; set; }

    public string? Telefon { get; set; }

    public string? Eposta { get; set; }

    public int? Kapasite { get; set; }

    public virtual ICollection<Hayvanlar> Hayvanlars { get; set; } = new List<Hayvanlar>();
}
