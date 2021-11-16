using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.Entidades
{
    public class Materias
    {
        [Key]
        public int UsuariosId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public Roles Roles { get; set; }
    }
}
