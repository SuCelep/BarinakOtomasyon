using System;
using System.Collections.Generic;

namespace barinakOto.Models;

public partial class Sahiplenmeler
{
    public int Id { get; set; }

    public DateTime? SahiplenmeTarihi { get; set; }

    public string? Notlar { get; set; }

    public int HayvanId { get; set; }

    public int SahiplenenId { get; set; }

    public virtual Hayvanlar Hayvan { get; set; } = null!;

    public virtual Sahiplenenler Sahiplenen { get; set; } = null!;
}
