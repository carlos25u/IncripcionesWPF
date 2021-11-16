using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    class Cursos
    {
        [Key]
        public int CursoId { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
    }
}
