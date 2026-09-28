
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class TratamientosController : Controller
{
    // GET: TRATAMIENTOS
    public ActionResult Index()
    {
        var tratamientos = CRUD<Tratamiento>.GetAll();
        return View(tratamientos);
    }

    // GET: TRATAMIENTOS/Details/5
    public ActionResult Details(int idtratamiento)
    {
        var tratamiento = CRUD<Tratamiento>.GetById(idtratamiento);
        if (tratamiento == null)
        {
            return NotFound();
        }
        return View(tratamiento);
    }

    // GET: TRATAMIENTOS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: TRATAMIENTOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Tratamiento tratamiento)
    {
        try
        {
            CRUD<Tratamiento>.Create(tratamiento);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(tratamiento);
        }

    }

    // GET: TRATAMIENTOS/Edit/5
    public ActionResult Edit(int idtratamiento)
    {
        var tratamiento = CRUD<Tratamiento>.GetById(idtratamiento);
        if (tratamiento == null)
        {
            return NotFound();
        }
        return View(tratamiento);
    }

    // POST: TRATAMIENTOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int idtratamiento, Tratamiento tratamiento)
    {
        try
        {
            CRUD<Tratamiento>.Update(idtratamiento, tratamiento);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(tratamiento);
        }
    }

    // GET: TRATAMIENTOS/Delete/5
    public IActionResult Delete(int idtratamiento)
    {
        var tratamiento = CRUD<Tratamiento>.GetById(idtratamiento);
        if (tratamiento == null)
        {
            return NotFound();
        }
        return View(tratamiento);
    }

    // POST: TRATAMIENTOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int idtratamiento, Tratamiento tratamiento)
    {
        try
        {
            CRUD<Tratamiento>.Delete(idtratamiento);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {

            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }
}
