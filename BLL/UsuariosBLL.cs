﻿using IncripcionesWPF.DAL;
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
    public class UsuariosBLL
    {
        public static bool Guardar(Materias usuario)
        {
            if (!Existe(usuario.UsuariosId))
            {
                return Insertar(usuario);
            }
            else
            {
                return Modificar(usuario);
            }
        }

        private static bool Insertar(Materias usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuarios.Add(usuario);
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
        private static bool Modificar(Materias usuario)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;
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
                var usuario = contexto.Usuarios.Find(id);
                if (usuario != null)
                {
                    contexto.Usuarios.Remove(usuario);
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
            Materias usuario;

            try
            {
                usuario = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return usuario;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuarios.Any(e => e.UsuariosId == id);
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
                lista = contexto.Usuarios.ToList();
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
                lista = contexto.Usuarios.Where(criterio).ToList();
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
