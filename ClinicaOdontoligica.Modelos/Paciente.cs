using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table ("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [MaxLength(10)]
        [Required]
        public string dni { get; set; }

        [MaxLength(50)]
        [Required]
        public string nombres { get; set; }

        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("fecha_nacimiento")]
        [Required]
        public DateOnly fechaNacimiento { get; set; }

        [MaxLength(25)]
        [Required]
        public string email { get; set; }

        [MaxLength(10)]
        [Required]
        public string telefono { get; set; }

        public List<Cita>? Citas { get; set; } = new List<Cita>();
    }
}
