using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class Cursos
    {
        [Key]
        public int CursoId { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }

        [ForeignKey("CursoId")]
        public List<CursosDetalle> Detalle { get; set; } = new List<CursosDetalle>();
    }
}
