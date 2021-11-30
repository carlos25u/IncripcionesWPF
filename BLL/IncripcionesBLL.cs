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
    class IncripcionesBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Incripciones.Any(e => e.IncripcionId == id);
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

        public static bool Guardar(Incripciones incripcion)
        {
            if (!Existe(incripcion.IncripcionId))
            {
                return Insertar(incripcion);
            }
            else
            {
                return Modificar(incripcion);
            }
        }

        private static bool Insertar(Incripciones incripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Incripciones.Add(incripcion);
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
        public static bool Modificar(Incripciones incripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(incripcion).State = EntityState.Modified;
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

        public static bool ExisteEstudiante(String nombre)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();
            try
            {
                encontrado = contexto.Incripciones.Any(e => e.Estudiantes.Nombre == nombre);
            }
            catch (Exception)
            {

            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var incripcion = contexto.Materias.Find(id);

                if (incripcion != null)
                {
                    contexto.Materias.Remove(incripcion);
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

        public static Incripciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Incripciones incripciones;

            try
            {
                incripciones = contexto.Incripciones.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return incripciones;
        }

        public static List<Incripciones> GetList(Expression<Func<Incripciones, bool>> criterio)
        {
            List<Incripciones> lista = new List<Incripciones>();
            Contexto contexto = new Contexto();
            try
            {

                lista = contexto.Incripciones.Where(criterio).ToList();
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

        public static List<Incripciones> GetIncripciones()
        {
            List<Incripciones> lista = new List<Incripciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Incripciones.ToList();
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
