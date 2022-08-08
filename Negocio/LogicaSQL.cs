using AccesosDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class LogicaSQL : ILogicaSQL
    {
        #region Atributo
        private readonly IAccesosDatosSQL _iaccesoSQL;
        #endregion

        #region Constructor
        public LogicaSQL(IAccesosDatosSQL iaccesoSQL)
        {
            _iaccesoSQL = iaccesoSQL;
        }
        #endregion

        #region CRUD Tablas
        #region Choferes
        /// <summary>
        /// Metodo para Agregar Tbl Choferes
        /// </summary>
        public bool AgregarChoferes(TblChofere P_Entidad)
        {
            return _iaccesoSQL.AgregarChoferes(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Choferes
        /// </summary>
        public List<TblChofere> ConsultarChoferes(TblChofere P_Entidad)
        {
            return _iaccesoSQL.ConsultarChoferes(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Choferes
        /// </summary>
        public bool EliminarChoferes(TblChofere P_Entidad)
        {
            return _iaccesoSQL.EliminarChoferes(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Choferes
        /// </summary>
        public bool ModificarChoferes(TblChofere P_Entidad)
        {
            return _iaccesoSQL.ModificarChoferes(P_Entidad);
        }

        #endregion

        #region Estados
        /// <summary>
        /// Metodo para Agregar Tbl Estados
        /// </summary>
        public bool AgregarEstados(TblEstado P_Entidad)
        {
            return _iaccesoSQL.AgregarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Estados
        /// </summary>
        public List<TblEstado> ConsultarEstados(TblEstado P_Entidad)
        {
            return _iaccesoSQL.ConsultarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Estados
        /// </summary>
        public bool EliminarEstados(TblEstado P_Entidad)
        {
            return _iaccesoSQL.EliminarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Estados
        /// </summary>
        public bool ModificarEstados(TblEstado P_Entidad)
        {
            return _iaccesoSQL.ModificarEstados(P_Entidad);
        }
        #endregion

        #region Perfiles
        /// <summary>
        /// Metodo para Agregar Tbl Perfiles
        /// </summary>
        public bool AgregarPerfiles(TblPerfile P_Entidad)
        {
            return _iaccesoSQL.AgregarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Perfiles
        /// </summary>
        public List<TblPerfile> ConsultarPerfiles(TblPerfile P_Entidad)
        {
            return _iaccesoSQL.ConsultarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Perfiles
        /// </summary>
        public bool EliminarPerfiles(TblPerfile P_Entidad)
        {
            return _iaccesoSQL.EliminarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Perfiles
        /// </summary>
        public bool ModificarPerfiles(TblPerfile P_Entidad)
        {
            return _iaccesoSQL.ModificarPerfiles(P_Entidad);
        }
        #endregion

        #region Rutas
        /// <summary>
        /// Metodo para Agregar Tbl Ruta
        /// </summary>
        public bool AgregarRuta(TblRutum P_Entidad)
        {
            return _iaccesoSQL.AgregarRuta(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Ruta
        /// </summary>
        public List<TblRutum> ConsultarRuta(TblRutum P_Entidad)
        {
            return _iaccesoSQL.ConsultarRuta(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Ruta
        /// </summary>
        public bool EliminarRuta(TblRutum P_Entidad)
        {
            return _iaccesoSQL.EliminarRuta(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Ruta
        /// </summary>
        public bool ModificarRuta(TblRutum P_Entidad)
        {
            return _iaccesoSQL.ModificarRuta(P_Entidad);
        }
        #endregion

        #region Usuarios
        /// <summary>
        /// Metodo para Agregar Tbl Usuarios
        /// </summary>
        public bool AgregarUsuario(TblUsuario P_Entidad)
        {
            return _iaccesoSQL.AgregarUsuario(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Usuarios
        /// </summary>
        public List<TblUsuario> ConsultarUsuario(TblUsuario P_Entidad)
        {
            return _iaccesoSQL.ConsultarUsuario(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Usuarios
        /// </summary>
        public bool EliminarUsuario(TblUsuario P_Entidad)
        {
            return _iaccesoSQL.EliminarUsuario(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Usuarios
        /// </summary>
        public bool ModificarUsuario(TblUsuario P_Entidad)
        {
            return _iaccesoSQL.ModificarUsuario(P_Entidad);
        }
        #endregion

        #region Vehiculos
        /// <summary>
        /// Metodo para Agregar Tbl Vehiculos-Buses
        /// </summary>
        public bool AgregarVehiculos(TblVehiculo P_Entidad)
        {
            
            return _iaccesoSQL.AgregarVehiculo(P_Entidad);
        }

        /// <summary>
        /// Metodo para Consultar Tbl Vehiculos-Buses
        /// </summary>
        public List<TblVehiculo> ConsultarVehiculos(TblVehiculo P_Entidad)
        {
            return _iaccesoSQL.ConsultarVehiculo(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Tbl Vehiculos-Buses
        /// </summary>
        public bool EliminarVehiculos(TblVehiculo P_Entidad)
        {
            return _iaccesoSQL.EliminarVehiculo(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Tbl Vehiculos-Buses
        /// </summary>
        public bool ModificarVehiculos(TblVehiculo P_Entidad)
        {
            return _iaccesoSQL.ModificarVehiculo(P_Entidad);
        }
        #endregion

        #endregion

    }
}
