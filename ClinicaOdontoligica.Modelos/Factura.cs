using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontoligica.Modelos
{
    [Table("facturas")]
    internal class Factura
    {
        [Key]
        public int idFactura { get; set; }
        public DateTime fechaEmision { get; set; }
        public decimal subtotal { get; set; }
        public decimal impuestos { get; set; }
        public string estadoPado { get; set; } 

        // Llave Foránea
        public int IdCita { get; set; }

    }
}
