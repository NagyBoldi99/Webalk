using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class Esemenyek
{
    public int Esemenyid { get; set; }

    public string Esemenynev { get; set; } = null!;

    public DateTime Datum { get; set; }

    public string Helyszin { get; set; } = null!;

    public string Leiras { get; set; } = null!;

    public virtual ICollection<EseményResztvevok> EseményResztvevoks { get; set; } = new List<EseményResztvevok>();
}
