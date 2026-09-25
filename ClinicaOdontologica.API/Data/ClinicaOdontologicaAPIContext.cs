using ClinicaOdontoligica.Modelos;
using Microsoft.EntityFrameworkCore;

public class ClinicaOdontologicaAPIContext(DbContextOptions<ClinicaOdontologicaAPIContext> options) : DbContext(options)
{
    public DbSet<ClinicaOdontoligica.Modelos.Cita> Citas { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Consultorio> Consultorios { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Paciente> Pacientes { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Odontologo> Odontologos { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Tratamiento> Tratamientos { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.DetalleCita> DetallesCitas { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Factura> Facturas { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.HistorialMedico> HistorialesMedicos { get; set; } = default!;
    public DbSet<ClinicaOdontoligica.Modelos.Receta> Recetas { get; set; } = default!;
}
