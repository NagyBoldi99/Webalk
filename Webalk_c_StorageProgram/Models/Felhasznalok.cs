using System;
using System.Collections.Generic;

namespace Webalk_c_StorageProgram.Models;

public partial class Felhasznalok
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SzuletesiHely { get; set; } = null!;

    public DateTime? SzuletesiDatum { get; set; }

    public string Neme { get; set; } = null!;

    public string TemaSzine { get; set; } = null!;

    public string KedvencTema { get; set; } = null!;

    public string Jelszo { get; set; } = null!;

    public virtual ICollection<BerlesVasarla> BerlesVasarlas { get; set; } = new List<BerlesVasarla>();

    public virtual ICollection<EseményResztvevok> EseményResztvevoks { get; set; } = new List<EseményResztvevok>();

    public virtual ICollection<Raktarak> Raktaraks { get; set; } = new List<Raktarak>();
}
