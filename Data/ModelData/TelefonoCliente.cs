using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Keyless]
    [Table("telefono_cliente")]
    public partial class TelefonoCliente
    {
        [Column("id_cliente", TypeName = "numeric(18, 0)")]
        public decimal IdCliente { get; set; }
        [Column("id_tipo_telefono", TypeName = "numeric(18, 0)")]
        public decimal IdTipoTelefono { get; set; }
        [Column("telefono")]
        [StringLength(50)]
        [Unicode(false)]
        public string Telefono { get; set; } = null!;

        [ForeignKey("IdCliente")]
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        [ForeignKey("IdTipoTelefono")]
        public virtual TipoTelefono IdTipoTelefonoNavigation { get; set; } = null!;
    }
}
