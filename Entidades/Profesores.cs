using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    class Profesores
    {
        [Key]
        public int ProfesorId { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int AreaId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String Correo { get; set; }
    }
}
