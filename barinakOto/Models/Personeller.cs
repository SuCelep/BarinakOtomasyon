using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Personeller
{
    public int Id { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string? Gorev { get; set; }

    public string? Telefon { get; set; }

    public string? Eposta { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? SifreHash { get; set; }

    public int? BarınakId { get; set; }
}
