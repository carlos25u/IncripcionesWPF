using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class Materias
    {
        [Key]
        public int MateriaId { get; set; }
        public String CodigoMateria { get; set; }
        public String Nombre { get; set; }
    }
}
