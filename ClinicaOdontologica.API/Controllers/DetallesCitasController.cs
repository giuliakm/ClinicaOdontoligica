using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontoligica.Modelos;

[Route("api/[controller]")]
[ApiController]
public class DetallesCitasController : ControllerBase
{
    private readonly ClinicaOdontologicaAPIContext _context;
    public DetallesCitasController(ClinicaOdontologicaAPIContext context)
    {
        _context = context;
    }

    // GET: api/DetalleCita
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DetalleCita>>> GetDetalleCita()
    {
        return await _context.DetallesCitas.ToListAsync();
    }

    // GET: api/DetalleCita/5
    [HttpGet("{iddetallecita}")]
    public async Task<ActionResult<DetalleCita>> GetDetalleCita(int iddetallecita)
    {
        var detallecita = await _context.DetallesCitas.FindAsync(iddetallecita);

        if (detallecita == null)
        {
            return NotFound();
        }

        return detallecita;
    }

    // PUT: api/DetalleCita/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{iddetallecita}")]
    public async Task<IActionResult> PutDetalleCita(int? iddetallecita, DetalleCita detallecita)
    {
        if (iddetallecita != detallecita.idDetalleCita)
        {
            return BadRequest();
        }

        _context.Entry(detallecita).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DetalleCitaExists(iddetallecita))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/DetalleCita
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<DetalleCita>> PostDetalleCita(DetalleCita detallecita)
    {
        _context.DetallesCitas.Add(detallecita);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDetalleCita", new { iddetallecita = detallecita.idDetalleCita }, detallecita);
    }

    // DELETE: api/DetalleCita/5
    [HttpDelete("{iddetallecita}")]
    public async Task<IActionResult> DeleteDetalleCita(int? iddetallecita)
    {
        var detallecita = await _context.DetallesCitas.FindAsync(iddetallecita);
        if (detallecita == null)
        {
            return NotFound();
        }

        _context.DetallesCitas.Remove(detallecita);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DetalleCitaExists(int? iddetallecita)
    {
        return _context.DetallesCitas.Any(e => e.idDetalleCita == iddetallecita);
    }
}
