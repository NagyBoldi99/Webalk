using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class EseményResztvevok
{
    public int ResztvevoId { get; set; }

    public int EsemenyId { get; set; }

    public int FelhasznaloId { get; set; }

    public virtual Esemenyek Esemeny { get; set; } = null!;

    public virtual Felhasznalok Felhasznalo { get; set; } = null!;
}
