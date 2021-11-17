using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class CursosDetalle
    {
        [Key]
        public int CursoDetalleId { get; set; }
        public int CursoId { get; set; }
        public int MateriaId { get; set; }

        [ForeignKey("MateriaId")]
        public Materias Materias { get; set; }
        public Cursos Cursos { get; set; }
    }
}
