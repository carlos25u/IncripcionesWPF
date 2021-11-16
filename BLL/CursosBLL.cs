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
    class CursosBLL
    {
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Cursos.Any(e => e.CursoId == id);
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

        public static bool Guardar(Cursos curso)
        {
            if (!Existe(curso.CursoId))
            {
                return Insertar(curso);
            }
            else
            {
                return Modificar(curso);
            }
        }

        private static bool Insertar(Cursos curso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Cursos.Add(curso);
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
        public static bool Modificar(Cursos curso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(curso).State = EntityState.Modified;
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
                var curso = contexto.Cursos.Find(id);

                if (curso != null)
                {
                    contexto.Cursos.Remove(curso);
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

        public static Cursos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cursos curso;

            try
            {
                curso = contexto.Cursos.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return curso;
        }

        public static List<Cursos> GetList(Expression<Func<Cursos, bool>> criterio)
        {
            List<Cursos> lista = new List<Cursos>();
            Contexto contexto = new Contexto();
            try
            {

                lista = contexto.Cursos.Where(criterio).ToList();
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

        public static List<Cursos> GetCursos()
        {
            List<Cursos> lista = new List<Cursos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Cursos.ToList();
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
