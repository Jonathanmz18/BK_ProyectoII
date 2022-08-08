using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesosDatos
{
    public class AccesosDatosSQL : IAccesosDatosSQL
    {
        #region Choferes
        /// <summary>
        /// Metodo para Insertar AgregarChoferes
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarChoferes(TblChofere P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblChoferes.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
       
        /// <summary>
        /// Metodo para ConsultarChoferes
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblChofere> ConsultarChoferes(TblChofere P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblChofere> lista = new List<TblChofere>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.IdChoferes == null ||P_Entidad.IdChoferes == 0)
                {
                    var consulta = (from x in contexto.TblChoferes
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblChoferes
                                    where x.IdChoferes.Equals(P_Entidad.IdChoferes)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Metodo para  EliminarChoferes
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarChoferes(TblChofere P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblChoferes
                                where x.IdChoferes.Equals(P_Entidad.IdChoferes)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblChoferes.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Modifcar Choferes
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarChoferes(TblChofere P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblChoferes
                                where x.IdChoferes.Equals(P_Entidad.IdChoferes)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.IdChoferes = P_Entidad.IdChoferes;
                    consulta.Identidad = P_Entidad.Identidad;
                    consulta.NombreApellidos = P_Entidad.NombreApellidos;
                    consulta.Edad = P_Entidad.Edad;
                    consulta.IdVehiculo = P_Entidad.IdVehiculo;
                    consulta.IdEstado = P_Entidad.IdEstado;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        #endregion

        #region Estados
        /// <summary>
        /// Metodo para Insertar Agregar Estados
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarEstados(TblEstado P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblEstados.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Insertar Consultar Estados
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblEstado> ConsultarEstados(TblEstado P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblEstado> lista = new List<TblEstado>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.DescEstado==null || P_Entidad.DescEstado.Length == 0)
                {
                    var consulta = (from x in contexto.TblEstados
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblEstados
                                    where x.DescEstado.Equals(P_Entidad.DescEstado)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Metodo para Insertar Eliminar Estados
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarEstados(TblEstado P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblEstados
                                where x.IdEstado.Equals(P_Entidad.IdEstado)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblEstados.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Insertar Modificar Estados
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarEstados(TblEstado P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblEstados
                                where x.IdEstado.Equals(P_Entidad.IdEstado)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.IdEstado = P_Entidad.IdEstado;
                    consulta.DescEstado = P_Entidad.DescEstado;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        #endregion

        #region Perfiles

        /// <summary>
        /// Metodo para Insertar Agregar Perfiles
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarPerfiles(TblPerfile P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblPerfiles.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Consultar Perfiles
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblPerfile> ConsultarPerfiles(TblPerfile P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblPerfile> lista = new List<TblPerfile>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.Descripcion == null|| P_Entidad.Descripcion.Length == 0)
                {
                    var consulta = (from x in contexto.TblPerfiles
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblPerfiles
                                    where x.Descripcion.Equals(P_Entidad.Descripcion)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Metodo para Modificar Perfiles
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarPerfiles(TblPerfile P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblPerfiles
                                where x.IdPerfil.Equals(P_Entidad.IdPerfil)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.IdPerfil = P_Entidad.IdPerfil;
                    consulta.Descripcion = P_Entidad.Descripcion;
                    consulta.IdEstado = P_Entidad.IdEstado;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Eliminar Perfiles
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarPerfiles(TblPerfile P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblPerfiles
                                where x.IdPerfil.Equals(P_Entidad.IdPerfil)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblPerfiles.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        #endregion

        #region Ruta
        /// <summary>
        /// Metodo para Insertar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarRuta(TblRutum P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblRuta.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Modificar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarRuta(TblRutum P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblRuta
                                where x.IdRuta.Equals(P_Entidad.IdRuta)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.IdRuta = P_Entidad.IdRuta;
                    consulta.DescripcionRuta = P_Entidad.DescripcionRuta;
                    consulta.Paradas = P_Entidad.Paradas;
                    consulta.MontoFinal = P_Entidad.MontoFinal;
                    consulta.MontoInicial = P_Entidad.MontoInicial;
                    consulta.IdChoferes = P_Entidad.IdChoferes;
                    consulta.IdEstado = P_Entidad.IdEstado;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
      
        /// <summary>
        /// Metodo para Eliminar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarRuta(TblRutum P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblRuta
                                where x.IdRuta.Equals(P_Entidad.IdRuta)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblRuta.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        
        /// <summary>
        /// Metodo para Consultar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblRutum> ConsultarRuta(TblRutum P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblRutum> lista = new List<TblRutum>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.DescripcionRuta == null|| P_Entidad.DescripcionRuta.Length == 0)
                {
                    var consulta = (from x in contexto.TblRuta
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblRuta
                                    where x.DescripcionRuta.Equals(P_Entidad.DescripcionRuta)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }
        #endregion

        #region Usuarios
        /// <summary>
        /// Metodo para Insertar Usuarios
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarUsuario(TblUsuario P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblUsuarios.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Consultar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblUsuario> ConsultarUsuario(TblUsuario P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblUsuario> lista = new List<TblUsuario>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.Username == null || P_Entidad.Username.Length == 0)
                {
                    var consulta = (from x in contexto.TblUsuarios
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblUsuarios
                                    where x.Username.Equals(P_Entidad.Username)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Metodo para Modificar Usuarios
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarUsuario(TblUsuario P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblUsuarios
                                where x.Username.Equals(P_Entidad.Username)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.Username = P_Entidad.Username;
                    consulta.Contrasena = P_Entidad.Contrasena;
                    consulta.IdEstado = P_Entidad.IdEstado;
                    consulta.IdPerfil = P_Entidad.IdPerfil;
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Eliminar Ruta
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarUsuario(TblUsuario P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblUsuarios
                                where x.Username.Equals(P_Entidad.Username)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblUsuarios.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        #endregion

        #region Vehiculo-Buses
        /// <summary>
        /// Metodo para Agregar Buses
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool AgregarVehiculo(TblVehiculo P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                contexto.TblVehiculos.Add(P_Entidad);
                contexto.SaveChanges();
                resultado = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

         

            return resultado;
        }

        /// <summary>
        /// Metodo para Consultar Buses
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public List<TblVehiculo> ConsultarVehiculo(TblVehiculo P_Entidad)
        {
            DB_EMPRESA_AUTOBUSERAContext contexto = null;
            List<TblVehiculo> lista = new List<TblVehiculo>();
            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();

                if (P_Entidad.IdVehiculo == null||P_Entidad.IdVehiculo == 0)
                {
                    var consulta = (from x in contexto.TblVehiculos
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
                else
                {
                    var consulta = (from x in contexto.TblVehiculos
                                    where x.IdVehiculo.Equals(P_Entidad.IdVehiculo)
                                    select x).ToList();

                    if (consulta != null)
                    {
                        consulta.ForEach(x =>
                        {
                            lista.Add(x);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Metodo para Eliminar Buses
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool EliminarVehiculo(TblVehiculo P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblVehiculos
                                where x.IdVehiculo.Equals(P_Entidad.IdVehiculo)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    contexto.TblVehiculos.Remove(consulta);
                    contexto.SaveChanges();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para Modificar Buses
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public bool ModificarVehiculo(TblVehiculo P_Entidad)
        {
            bool resultado = false;
            DB_EMPRESA_AUTOBUSERAContext contexto = null;

            try
            {
                contexto = new DB_EMPRESA_AUTOBUSERAContext();
                var consulta = (from x in contexto.TblVehiculos
                                where x.IdVehiculo.Equals(P_Entidad.IdVehiculo)
                                select x).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.IdVehiculo = P_Entidad.IdVehiculo;
                    consulta.PlacaVehiculo = P_Entidad.PlacaVehiculo;
                    consulta.Fabricante = P_Entidad.Fabricante;
                    consulta.AñoFabricacion = P_Entidad.AñoFabricacion;
                    consulta.IdEstado = P_Entidad.IdEstado;
                    
                    contexto.SaveChanges();
                    resultado = true;
    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return resultado;
        }
        #endregion
    }
}
