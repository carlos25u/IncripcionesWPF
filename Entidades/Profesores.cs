using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public String Celular { get; set; }
        public int AreaId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public String Correo { get; set; }

        [ForeignKey("ProfesorId")]
        public List<ProfesoresDetalle> Detalle { get; set; } = new List<ProfesoresDetalle>();

        [ForeignKey("AreaId")]
        public Areas Areas { get; set; }

    }
}
