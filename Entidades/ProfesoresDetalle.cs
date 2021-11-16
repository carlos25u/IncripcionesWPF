using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("MateriaId")]
        public Materias Materias { get; set; }
        public Profesores Profesores { get; set; }
    }
}
