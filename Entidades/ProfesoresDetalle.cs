using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    class ProfesoresDetalle
    {
        [Key]
        public int ProfesorDetalleId { get; set; }
        public int ProfesorId { get; set; }
        public int MateriaId { get; set; }
    }
}
