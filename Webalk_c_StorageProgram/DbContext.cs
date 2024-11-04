using Microsoft.EntityFrameworkCore;

public class RaktarAlkalmazasContext : DbContext
{
    public RaktarAlkalmazasContext(DbContextOptions<RaktarAlkalmazasContext> options) : base(options) { }

    public DbSet<Felhasznalok> Felhasznalok { get; set; }
    public DbSet<Raktarak> Raktarak { get; set; }
    public DbSet<Esemenyek> Esemenyek { get; set; }
    public DbSet<Berles_Vasarlas> Berles_Vasarlas { get; set; }
    public DbSet<Esemeny_Resztvevok> Esemény_Resztvevok { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseOracle("name=ConnectionStrings:RaktarAlkalmazasDB");
    }
}
