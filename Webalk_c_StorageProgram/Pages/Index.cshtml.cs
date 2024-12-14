using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class IndexModel : PageModel
{
    private readonly RaktarAlkalmazasContext _context;

    public List<Esemenyek> Esemenyek { get; set; }

    public IndexModel(RaktarAlkalmazasContext context)
    {
        _context = context;
    }

    public async Task OnGetAsync()
{
    Esemenyek = await _context.Esemenyek.ToListAsync();
    if (Esemenyek == null || !Esemenyek.Any())
    {
        Console.WriteLine("Nincsenek események az adatbázisban.");
    }
    else
    {
        Console.WriteLine($"{Esemenyek.Count} események lettek lekérve.");
    }
}

}

