using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class Raktarak
{
    public int RaktarId { get; set; }

    public float Terulet { get; set; }

    public decimal ArBerles { get; set; }

    public decimal ArVetel { get; set; }

    public string RaktarSzam { get; set; } = null!;

    public string Cim { get; set; } = null!;

    public int? TulajdonosId { get; set; }

    public virtual ICollection<BerlesVasarla> BerlesVasarlas { get; set; } = new List<BerlesVasarla>();

    public virtual Felhasznalok? Tulajdonos { get; set; }
}
