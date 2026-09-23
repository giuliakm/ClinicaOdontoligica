using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table("citas")]
    internal class Cita
    {
        [Key]
        public int idCita {  get; set; }
        public DateTime fechaCita { get; set; }
        public string motivo { get; set; }
        public string estadoCita { get; set; }

        // Llaves foráneas
        public int IdPaciente { get; set; }
        public int IdOdontologo {  get; set; }
        public int idConsultorio { get; set; }

    }
}
