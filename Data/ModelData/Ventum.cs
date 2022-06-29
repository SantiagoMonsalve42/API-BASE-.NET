using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("venta")]
    public partial class Ventum
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Column("id_cliente", TypeName = "numeric(18, 0)")]
        public decimal IdCliente { get; set; }
        [Column("descuento", TypeName = "numeric(18, 2)")]
        public decimal Descuento { get; set; }
        [Column("monto_final", TypeName = "numeric(18, 0)")]
        public decimal MontoFinal { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("Venta")]
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
    }
}
