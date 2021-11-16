using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class Areas
    {
        [Key]
        public int AreaId { get; set; }
        public String Descripcion { get; set; }
    }
}
