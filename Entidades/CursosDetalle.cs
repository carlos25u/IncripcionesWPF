using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class CursosDetalle
    {
        [Key]
        public int CursoId { get; set; }
        public int MateriaId { get; set; }
        
       
    }
}
