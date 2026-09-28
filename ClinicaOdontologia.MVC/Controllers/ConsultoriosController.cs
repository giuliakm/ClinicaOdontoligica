
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ConsultoriosController : Controller
{
    // GET: CITAS
    public ActionResult Index()
    {
        var consultorios = CRUD<Consultorio>.GetAll();
        return View(consultorios);
    }

    // GET: CITAS/Details/5
    public ActionResult Details(int idconsultorio)
    {
        var consultorio = CRUD<Consultorio>.GetById(idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }
        return View(consultorio);
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
    public ActionResult Create(Consultorio consultorio)
    {
        try
        {
            CRUD<Consultorio>.Create(consultorio);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(consultorio);
        }

    }

    // GET: CITAS/Edit/5
    public ActionResult Edit(int idconsultorio)
    {
        var consultorio = CRUD<Consultorio>.GetById(idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }
        return View(consultorio);
    }

    // POST: CITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int idconsultorio, Consultorio consultorio)
    {
        try
        {
            CRUD<Consultorio>.Update(idconsultorio, consultorio);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(consultorio);
        }
    }

    // GET: CITAS/Delete/5
    public IActionResult Delete(int idconsultorio)
    {
        var consultorio = CRUD<Consultorio>.GetById(idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }
        return View(consultorio);
    }

    // POST: CITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int idconsultorio, Consultorio consultorio)
    {
        try
        {
            CRUD<Consultorio>.Delete(idconsultorio);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {

            ModelState.AddModelError("", ex.Message);
            return View();
        }
    }
}
