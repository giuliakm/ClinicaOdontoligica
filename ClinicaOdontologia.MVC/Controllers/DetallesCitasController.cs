
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class DetallesCitasController : Controller
{
    // GET: CITAS
    public ActionResult Index()
    {
        var detallescitas = CRUD<DetalleCita>.GetAll();
        return View(detallescitas);
    }

    // GET: CITAS/Details/5
    public ActionResult Details(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (detallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // GET: CITAS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: CITAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Create(detallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(detallecita);
        }

    }

    // GET: CITAS/Edit/5
    public ActionResult Edit(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (detallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // POST: CITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int iddetallecita, DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Update(iddetallecita, detallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(detallecita);
        }
    }

    // GET: CITAS/Delete/5
    public IActionResult Delete(int iddetallecita)
    {
        var detallecita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (detallecita == null)
        {
            return NotFound();
        }
        return View(detallecita);
    }

    // POST: CITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int iddetallecita, DetalleCita detallecita)
    {
        try
        {
            CRUD<DetalleCita>.Delete(iddetallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {

            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }
}
