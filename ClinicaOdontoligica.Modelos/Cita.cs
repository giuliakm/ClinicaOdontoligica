using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table("citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita", TypeName = "Serial")]       
        public int idCita {  get; set; }

        [Column("fecha_cita")]
        [Required]
        public DateTime fechaCita { get; set; }

        [Column("motivo")]
        [MaxLength(200)]
        public string motivo { get; set; }

        [Column("estado_cita")]
        [MaxLength(20)]
        public string estadoCita { get; set; }

        // Llaves foráneas
        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [ForeignKey("Odontologo")]
        [Column("id_odontologo")]
        public int IdOdontologo {  get; set; }

        [ForeignKey("Consultorio")]
        [Column("id_consultorio")]
        public int idConsultorio { get; set; }

        // Objetos de Navegacion
        public Paciente? Paciente { get; set; }
        public Odontologo? Odontologo { get; set; }
        public Consultorio? Consultorio { get; set; }


        public List<Receta>? Recetas { get; set; } = new List<Receta>();

        public List<Factura>? Facturas { get; set; } = new List<Factura>();

        public List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();
    }
}
