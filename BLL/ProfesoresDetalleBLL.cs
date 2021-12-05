using IncripcionesWPF.DAL;
using IncripcionesWPF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.BLL
{
    class ProfesoresDetalleBLL
    {
        public static List<ProfesoresDetalle> GetList(Expression<Func<ProfesoresDetalle, bool>> criterio)
        {
            var lista = new List<ProfesoresDetalle>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.ProfesoresDetalle.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
