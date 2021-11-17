using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    class Incripciones
    {
        [Key]
        public int IncripcionId { get; set; }
        public int CursoId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey("CursoId")]
        public Cursos Cursos { get; set; }

        [ForeignKey("EstudianteId")]
        public Estudiantes Estudiantes { get; set; }
    }
}
