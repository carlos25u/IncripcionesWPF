﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    class Roles
    {
        [Key]
        public int RolId { get; set; }
        public String Descripcion { get; set; }
    }
}
