using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("provedor")]
    public partial class Provedor
    {
        public Provedor()
        {
            Productos = new HashSet<Producto>();
        }

        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("nombre")]
        [StringLength(100)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;
        [Column("direccion")]
        [StringLength(100)]
        [Unicode(false)]
        public string Direccion { get; set; } = null!;
        [Column("pagina_web")]
        [StringLength(150)]
        [Unicode(false)]
        public string PaginaWeb { get; set; } = null!;
        [Column("rut")]
        [StringLength(50)]
        [Unicode(false)]
        public string Rut { get; set; } = null!;

        [InverseProperty("IdProvedorNavigation")]
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
