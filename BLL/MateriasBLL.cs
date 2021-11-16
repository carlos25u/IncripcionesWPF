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
    public class MateriasBLL
    {
        public static bool Guardar(Materias materia)
        {
            if (!Existe(materia.MateriaId))
            {
                return Insertar(materia);
            }
            else
            {
                return Modificar(materia);
            }
        }

        private static bool Insertar(Materias materia)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Materias.Add(materia);
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
        private static bool Modificar(Materias materia)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(materia).State = EntityState.Modified;
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
                var materia = contexto.Materias.Find(id);
                if (materia != null)
                {
                    contexto.Materias.Remove(materia);
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
        public static Materias Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Materias materia;

            try
            {
                materia = contexto.Materias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return materia;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Materias.Any(e => e.MateriaId == id);
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

        public static List<Materias> GetList()
        {
            List<Materias> lista = new List<Materias>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Materias.ToList();
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
        public static List<Materias> GetList(Expression<Func<Materias, bool>> criterio)
        {
            List<Materias> lista = new List<Materias>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Materias.Where(criterio).ToList();
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
