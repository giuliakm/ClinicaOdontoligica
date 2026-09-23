using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table("detallescita")]
    internal class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita", TypeName = "Serial")]
        public int idDetalleCita { get; set; }

        [Column("costo_aplicado", TypeName = "numeric(10,2)")]
        [Required]
        public decimal CostoAplicado { get; set; }

        [Column("observaciones")]
        [MaxLength(200)]
        public string observacion { get; set; }

        // Llaves Foraneas
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        [ForeignKey("Tratamiento")]
        [Column("id_tratamiento")]
        public int idTratamiento { get; set; }

        // Objetos de Nagacion
        public Cita? Cita { get; set; }
        public Tratamiento? Tratamiento { get; set; }
    }
}
