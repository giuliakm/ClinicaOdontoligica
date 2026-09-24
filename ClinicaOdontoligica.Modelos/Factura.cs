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
    public class Factura
    {
        [Key]
        [Column("id_factura", TypeName = "Serial")]
        public int idFactura { get; set; }

        [Column("fecha_emision", TypeName = "date")]
        [Required]
        public DateTime fechaEmision { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        [Required]
        public decimal subtotal { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        [Required]
        public decimal total { get; set; }

        [Column(TypeName = "numeric(10,2)")]
        [Required]
        public decimal impuestos { get; set; }

        [Column("estado_pago")]
        [MaxLength(20)]
        public string estadoPado { get; set; }

        // Llave Foránea
        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        // Objeto de Navegación
        public Cita? Cita { get; set; }
    }
}
