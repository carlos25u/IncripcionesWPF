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
    class ProfesoresBLL
    {
        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Profesores.Any(e => e.ProfesorId == id);
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

        public static bool Insertar(Profesores profesor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Profesores.Add(profesor);

                foreach (var detalle in profesor.Detalle)
                {
                    contexto.Entry(detalle).State = EntityState.Added;
                    contexto.Entry(detalle.Materias).State = EntityState.Modified;
                }

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

        public static bool Modificar(Profesores profesor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var ProfesorAnterior = contexto.Profesores
                     .Where(x => x.ProfesorId == profesor.ProfesorId)
                     .Include(x => x.Detalle)
                     .ThenInclude(x => x.Materias)
                     .AsNoTracking()
                     .SingleOrDefault();

                contexto.Database.ExecuteSqlRaw($"Delete FROM ProfesoresDetalle where ProfesorId={profesor.ProfesorId}");

                foreach (var item in profesor.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                    contexto.Entry(item.Materias).State = EntityState.Modified;

                }

                contexto.Entry(profesor).State = EntityState.Modified;
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

        public static bool Guardar(Profesores profesor)
        {
            if (!Existe(profesor.ProfesorId))
                return Insertar(profesor);
            else
                return Modificar(profesor);
        }

        public static Profesores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Profesores profesor = new Profesores();

            try
            {
                profesor = contexto.Profesores.Include(x => x.Detalle)
                    .Where(x => x.ProfesorId == id)
                    .Include(x => x.Detalle)
                    .ThenInclude(x => x.Materias)
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return profesor;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var profesor = contexto.Profesores.Find(id);

                foreach (var item in profesor.Detalle)
                {
                    contexto.Entry(item.Profesores).State = EntityState.Modified;
                    contexto.Entry(item.Materias).State = EntityState.Modified;
                }


                contexto.Entry(profesor).State = EntityState.Deleted;

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

        public static List<Profesores> GetList(Expression<Func<Profesores, bool>> criterio)
        {
            var lista = new List<Profesores>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Profesores.Where(criterio).ToList();
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

        public static List<Profesores> GetProfesores()
        {
            List<Profesores> lista = new List<Profesores>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Profesores.ToList();
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
