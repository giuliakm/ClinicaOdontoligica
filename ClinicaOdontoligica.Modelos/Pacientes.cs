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
    public class Pacientes
    {
        [Key]
        [Column("id_paciente")]
        public int idPaciente { get; set; }

        [Column("dni")]
        [MaxLength(10)]
        [Required]
        public string dni { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("fecha_nacimiento")]
        [Required]
        public DateOnly fechaNacimiento { get; set; }

        [Column("email")]
        [MaxLength(25)]
        [Required]
        public string email { get; set; }

        [Column("telefono")]
        [MaxLength(10)]
        [Required]
        public string telefono { get; set; }
    }
}
