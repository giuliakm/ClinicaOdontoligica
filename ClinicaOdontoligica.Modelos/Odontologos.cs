using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    public class Odontologos
    {
        [Key]
        [Column("id_odontologo")]
        public int idOdontologo { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string apellidos { get; set; }

        [Column("registro_medico")]
        [MaxLength(20)]
        [Required]
        public string registroMedico { get; set; }

        [Column("id_especialidad")]
        [Required]
        public int idEspecialidad { get; set; }
    }
}
