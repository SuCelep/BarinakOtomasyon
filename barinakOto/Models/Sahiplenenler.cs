using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Sahiplenenler
{
    public int Id { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string? Telefon { get; set; }

    public string? Eposta { get; set; }

    public string? Adres { get; set; }

    public string? KimlikNo { get; set; }

    public virtual ICollection<Sahiplenmeler> Sahiplenmelers { get; set; } = new List<Sahiplenmeler>();
}
