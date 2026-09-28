
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HistorialesMedicosController : Controller
{
    // GET: HISTORIALESMEDICOS
    public ActionResult Index()
    {
        var historialesmedicos = CRUD<HistorialMedico>.GetAll();
        return View(historialesmedicos);
    }

    // GET: HISTORIALESMEDICOS/Details/5
    public ActionResult Details(int idhistorialmedico)
    {
        var historialmedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (historialmedico == null)
        {
            return NotFound();
        }
        return View(historialmedico);
    }

    // GET: HISTORIALESMEDICOS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: HISTORIALESMEDICOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(HistorialMedico historialmedico)
    {
        try
        {
            CRUD<HistorialMedico>.Create(historialmedico);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(historialmedico);
        }

    }

    // GET: HISTORIALESMEDICOS/Edit/5
    public ActionResult Edit(int idhistorialmedico)
    {
        var historialmedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (historialmedico == null)
        {
            return NotFound();
        }
        return View(historialmedico);
    }

    // POST: HISTORIALESMEDICOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int idhistorialmedico, HistorialMedico historialmedico)
    {
        try
        {
            CRUD<HistorialMedico>.Update(idhistorialmedico, historialmedico);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(historialmedico);
        }
    }

    // GET: HISTORIALESMEDICOS/Delete/5
    public IActionResult Delete(int idhistorialmedico)
    {
        var historialmedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (historialmedico == null)
        {
            return NotFound();
        }
        return View(historialmedico);
    }

    // POST: HISTORIALESMEDICOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int idhistorialmedico, HistorialMedico historialmedico)
    {
        try
        {
            CRUD<HistorialMedico>.Delete(idhistorialmedico);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {

            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }
}
