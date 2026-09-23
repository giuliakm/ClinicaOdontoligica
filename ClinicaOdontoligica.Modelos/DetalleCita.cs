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
        public int idDetalleCita { get; set; }
        public decimal CostoAplicado { get; set; }
        public string observaciones { get; set; }

        // Llaves Foraneas
        public int IdCita { get; set; }
        public int idTratamiento { get; set; }
    }
}
