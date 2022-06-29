using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("tipo_documento")]
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("tipo")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tipo { get; set; } = null!;

        [InverseProperty("IdTipoDocumentoNavigation")]
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
