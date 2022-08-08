using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesosDatos
{
   public interface IAccesosDatosSQL
    {
        #region Choferes
        bool AgregarChoferes(TblChofere P_Entidad);
        bool ModificarChoferes(TblChofere P_Entidad);
        bool EliminarChoferes(TblChofere P_Entidad);
        List<TblChofere> ConsultarChoferes(TblChofere P_Entidad);
        #endregion

        #region Estados
        bool AgregarEstados(TblEstado P_Entidad);
        bool ModificarEstados(TblEstado P_Entidad);
        bool EliminarEstados(TblEstado P_Entidad);
        List<TblEstado> ConsultarEstados(TblEstado P_Entidad);
        #endregion

        #region Perfiles
        bool AgregarPerfiles(TblPerfile P_Entidad);
        bool ModificarPerfiles(TblPerfile P_Entidad);
        bool EliminarPerfiles(TblPerfile P_Entidad);
        List<TblPerfile> ConsultarPerfiles(TblPerfile P_Entidad);
        #endregion

        #region Ruta
        bool AgregarRuta(TblRutum P_Entidad);
        bool ModificarRuta(TblRutum P_Entidad);
        bool EliminarRuta(TblRutum P_Entidad);
        List<TblRutum> ConsultarRuta(TblRutum P_Entidad);
        #endregion

        #region Usuarios
        bool AgregarUsuario(TblUsuario P_Entidad);
        bool ModificarUsuario(TblUsuario P_Entidad);
        bool EliminarUsuario(TblUsuario P_Entidad);
        List<TblUsuario> ConsultarUsuario(TblUsuario P_Entidad);
        #endregion

        #region Vehiculo
        bool AgregarVehiculo(TblVehiculo P_Entidad);
        bool ModificarVehiculo(TblVehiculo P_Entidad);
        bool EliminarVehiculo(TblVehiculo P_Entidad);
        List<TblVehiculo> ConsultarVehiculo(TblVehiculo P_Entidad);
        #endregion
    }
}
