using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class BerlesVasarla
{
    public int TranzakcioId { get; set; }

    public int FelhasznaloId { get; set; }

    public int RaktarId { get; set; }

    public string Tipus { get; set; } = null!;

    public DateTime KezdesDatum { get; set; }

    public DateTime? VegDatum { get; set; }

    public decimal Ar { get; set; }

    public virtual Felhasznalok Felhasznalo { get; set; } = null!;

    public virtual Raktarak Raktar { get; set; } = null!;
}
