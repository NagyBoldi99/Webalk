using System;
using System.ComponentModel.DataAnnotations;

public class Esemenyek
{
    [Key]
    public int EsemenyId { get; set; }

    [Required]
    public string EsemenyNev { get; set; } // ENUM('Licit', 'Kiárusítás', 'Bolhapiac')

    [Required]
    public DateTime Datum { get; set; }

    [MaxLength(255)]
    public string Helyszin { get; set; }

    public string Leiras { get; set; }
}
