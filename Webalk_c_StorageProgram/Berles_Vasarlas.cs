using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Berles_Vasarlas
{
    [Key]
    public int TranzakcioId { get; set; }

    public int FelhasznaloId { get; set; }

    [ForeignKey("FelhasznaloId")]
    public Felhasznalok Felhasznalo { get; set; }

    public int RaktarId { get; set; }

    [ForeignKey("RaktarId")]
    public Raktarak Raktar { get; set; }

    [Required]
    public string Tipus { get; set; } // ENUM('Bérlés', 'Vétel')

    [Required]
    public DateTime KezdesDatum { get; set; }

    public DateTime? VegDatum { get; set; }

    public decimal Ar { get; set; }
}
