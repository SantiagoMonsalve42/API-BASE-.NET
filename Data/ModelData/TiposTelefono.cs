﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelData
{
    [Table("Tipos_Telefonos")]
    public partial class TiposTelefono
    {
        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TipoTelefono { get; set; } = null!;
    }
}
