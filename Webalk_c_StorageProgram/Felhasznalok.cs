using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Felhasznalok
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nev { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(100)]
    public string SzuletesiHely { get; set; }

    public DateTime? SzuletesiDatum { get; set; }

    public string Neme { get; set; }

    [MaxLength(7)]
    public string TemaSzine { get; set; }

    public string KedvencTema { get; set; }

    [Required]
    public string Jelszo { get; set; }
}

