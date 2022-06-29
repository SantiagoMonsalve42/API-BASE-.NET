using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("producto")]
    public partial class Producto
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;
        [Column("precio_actual", TypeName = "numeric(18, 2)")]
        public decimal PrecioActual { get; set; }
        [Column("stock", TypeName = "numeric(18, 0)")]
        public decimal Stock { get; set; }
        [Column("id_provedor", TypeName = "numeric(18, 0)")]
        public decimal IdProvedor { get; set; }

        [ForeignKey("IdProvedor")]
        [InverseProperty("Productos")]
        public virtual Provedor IdProvedorNavigation { get; set; } = null!;
    }
}
