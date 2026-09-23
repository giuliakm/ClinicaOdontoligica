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
        public int idReceta { get; set; }
        public DateTime fechaEmision { get; set; }
        public string indicaciones { get; set; }

        // Llave foránea
        public int IdCita { get; set; }
    }
}
