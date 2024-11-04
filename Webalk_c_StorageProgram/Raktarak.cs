using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Raktarak
{
    [Key]
    public int RaktarId { get; set; }

    public float Terulet { get; set; } // m²-ben

    public decimal ArBerles { get; set; } // Bérlési ár

    public decimal ArVetel { get; set; } // Eladási ár

    [Required]
    [MaxLength(50)]
    public string RaktarSzam { get; set; }

    [Required]
    [MaxLength(255)]
    public string Cim { get; set; }

    public int? TulajdonosId { get; set; }

    [ForeignKey("TulajdonosId")]
    public Felhasznalok Tulajdonos { get; set; }
}
