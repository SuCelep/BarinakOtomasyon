using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Hayvanlar
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Tur { get; set; } = null!;

    public string? Cins { get; set; }

    public int? Yas { get; set; }

    public string? Cinsiyet { get; set; }

    public string? Aciklama { get; set; }

    public bool? SahiplenildiMi { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int BarinakId { get; set; }

    public virtual ICollection<Asilar> Asilars { get; set; } = new List<Asilar>();

    public virtual Barinaklar Barinak { get; set; } = null!;

    public virtual ICollection<SaglikKayitlari> SaglikKayitlaris { get; set; } = new List<SaglikKayitlari>();

    public virtual Sahiplenmeler? Sahiplenmeler { get; set; }
}
