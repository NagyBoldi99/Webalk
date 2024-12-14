using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Webalk_c_StorageProgram.Models;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly RaktarAlkalmazasContext _context;

    public EventsController(RaktarAlkalmazasContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Esemenyek>>> GetEvents()
    {
        return await _context.Esemenyek.ToListAsync();
    }
}
