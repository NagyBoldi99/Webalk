using Microsoft.AspNetCore.Mvc;

public class RegisterController : Controller
{
    private readonly RaktarAlkalmazasContext _context;

    public RegisterController(RaktarAlkalmazasContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Register(Felhasznalok newUser)
    {
        _context.Felhasznalok.Add(newUser);
        await _context.SaveChangesAsync();
        return RedirectToAction("Welcome");
    }
}
