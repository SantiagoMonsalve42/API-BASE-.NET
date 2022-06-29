using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("tipo_telefono")]
    public partial class TipoTelefono
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("tipo")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tipo { get; set; } = null!;
    }
}
