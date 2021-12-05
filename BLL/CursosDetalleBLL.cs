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
    public class CursoDetalleBLL
    {
        public static List<CursosDetalle> GetList(Expression<Func<CursosDetalle, bool>> criterio)
        {
            List<CursosDetalle> lista = new List<CursosDetalle>();
            Contexto db = new Contexto();
            try
            {
                lista = db.CursosDetalle.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}

