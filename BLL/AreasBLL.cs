using IncripcionesWPF.DAL;
using IncripcionesWPF.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.BLL
{
    public class AreasBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Areas.Any(e => e.AreaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static bool ExisteArea(string Descripcion)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();
            try
            {
                encontrado = contexto.Areas.Any(e => e.Descripcion == Descripcion);
            }
            catch(Exception)
            {

            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool Guardar(Areas area)
        {
            if (!Existe(area.AreaId))
            {
                return Insertar(area);
            }
            else
            {
                return Modificar(area);
            }
        }

        private static bool Insertar(Areas area)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Areas.Add(area);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;

        }
        public static bool Modificar(Areas area)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(area).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var area = contexto.Areas.Find(id);

                if (area != null)
                {
                    contexto.Areas.Remove(area);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Areas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Areas area;

            try
            {
                area = contexto.Areas.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return area;
        }

        public static List<Areas> GetList(Expression<Func<Areas, bool>> criterio)
        {
            List<Areas> lista = new List<Areas>();
            Contexto contexto = new Contexto();
            try
            {

                lista = contexto.Areas.Where(criterio).ToList();
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

        public static List<Areas> GetAreas()
        {
            List<Areas> lista = new List<Areas>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Areas.ToList();
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
