using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Esemeny_Resztvevok
{
    [Key]
    public int ResztvevoId { get; set; }

    public int EsemenyId { get; set; }

    [ForeignKey("EsemenyId")]
    public Esemenyek Esemeny { get; set; }

    public int FelhasznaloId { get; set; }

    [ForeignKey("FelhasznaloId")]
    public Felhasznalok Felhasznalo { get; set; }
}
