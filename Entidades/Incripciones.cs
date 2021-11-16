using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Fecha { get; set; }
    }
}
