using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table("recetas")]
    internal class Receta
    {
        [Key]
        [Column("id_receta", TypeName = "Serial")]
        public int idReceta { get; set; }

        [Column("fecha_emision")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column("indicaciones")]
        [Required]
        public string indicaciones { get; set; }

        // Llave foránea
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        // Objeto de Navegación
        public Cita? Cita { get; set; }
    }
}
