using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Ventum>();
        }

        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("id_tipo_documento", TypeName = "numeric(18, 0)")]
        public decimal IdTipoDocumento { get; set; }
        [Column("nombre")]
        [StringLength(100)]
        [Unicode(false)]
        public string Nombre { get; set; } = null!;
        [Column("direccion")]
        [StringLength(100)]
        [Unicode(false)]
        public string Direccion { get; set; } = null!;

        [ForeignKey("IdTipoDocumento")]
        [InverseProperty("Clientes")]
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
