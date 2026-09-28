
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica.Modelos;
using Microsoft.EntityFrameworkCore;

CRUD<Cita>.Endpoint = "https://localhost:7244/api/Citas";
CRUD<Consultorio>.Endpoint = "https://localhost:7244/api/Consultorios";
CRUD<DetalleCita>.Endpoint = "https://localhost:7244/api/DetallesCitas";
CRUD<HistorialMedico>.Endpoint = "https://localhost:7244/api/HistorialesMedicos";
CRUD<Odontologo>.Endpoint = "https://localhost:7244/api/Odontologos";
CRUD<Paciente>.Endpoint = "https://localhost:7244/api/Pacientes";
CRUD<Receta>.Endpoint = "https://localhost:7244/api/Recetas";
CRUD<Tratamiento>.Endpoint = "https://localhost:7244/api/Tratamientos";

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ClinicaOdontologicaAPIContext") ?? throw new InvalidOperationException("Connection string 'ClinicaOdontologicaAPIContext' not found.");

builder.Services.AddDbContext<ClinicaOdontologicaAPIContext>(options => options.UseNpgsql(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
