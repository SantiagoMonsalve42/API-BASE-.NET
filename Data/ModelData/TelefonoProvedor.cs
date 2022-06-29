using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Keyless]
    [Table("telefono_provedor")]
    public partial class TelefonoProvedor
    {
        [Column("id_tipo_telefono", TypeName = "numeric(18, 0)")]
        public decimal IdTipoTelefono { get; set; }
        [Column("id_provedor", TypeName = "numeric(18, 0)")]
        public decimal IdProvedor { get; set; }
        [Column("telefono")]
        [StringLength(50)]
        [Unicode(false)]
        public string Telefono { get; set; } = null!;

        [ForeignKey("IdProvedor")]
        public virtual Provedor IdProvedorNavigation { get; set; } = null!;
        [ForeignKey("IdTipoTelefono")]
        public virtual TipoTelefono IdTipoTelefonoNavigation { get; set; } = null!;
    }
}
