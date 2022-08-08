using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Negocio;
using Entidades;

namespace WebApi.Controllers
{
    [Route("api/Autobusera")]
    [ApiController]
    public class AutobuseraController : Controller
    {

        private readonly ILogicaSQL _ilogicaSQL;
        private readonly ILogicaMongo _ilogicaMongo;
        public AutobuseraController(ILogicaSQL ilogica_SQL, ILogicaMongo ilogicaMongo)
        {
            _ilogicaSQL = ilogica_SQL;
            _ilogicaMongo = ilogicaMongo;
        }
        

        #region METODOS
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region METODOS CRUD SQL
        #region Estados
        /// <summary>
        /// Metodo para Consultar Estados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(ConsultarEstados))]
        public IEnumerable<TblEstado> ConsultarEstados(TblEstado P_Entidad)
        {
            return _ilogicaSQL.ConsultarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Estados
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(AgregarEstados))]
        public bool AgregarEstados(TblEstado P_Entidad)
        {
            return _ilogicaSQL.AgregarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Estados
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(ModificarEstados))]
        public bool ModificarEstados(TblEstado P_Entidad)
        {
            return _ilogicaSQL.ModificarEstados(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Estados
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(EliminarEstados))]
        public bool EliminarEstados(TblEstado P_Entidad)
        {
            return _ilogicaSQL.EliminarEstados(P_Entidad);
        }
        #endregion

        #region Perfiles
        /// <summary>
        /// Metodo para Consultar Perfiles
        /// </summary>
        [HttpPost]
        [Route(nameof(ConsultarPerfiles))]
        public IEnumerable<TblPerfile> ConsultarPerfiles(TblPerfile P_Entidad)
        {
            return _ilogicaSQL.ConsultarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Perfiles
        /// </summary>
               [HttpPost]
        [Route(nameof(AgregarPerfiles))]
        public bool AgregarPerfiles(TblPerfile P_Entidad)
        {
            return _ilogicaSQL.AgregarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Modificar Perfiles
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(ModificarPerfiles))]
        public bool ModificarPerfiles(TblPerfile P_Entidad)
        {
            return _ilogicaSQL.ModificarPerfiles(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Perfiles
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(EliminarPerfiles))]
        public bool EliminarPerfiles(TblPerfile P_Entidad)
        {
            return _ilogicaSQL.EliminarPerfiles(P_Entidad);
        }
        #endregion

        #region Usuarios
        /// <summary>
        /// Metodo para consultar Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(ConsultarUsuarios))]
        public IEnumerable<TblUsuario> ConsultarUsuarios(TblUsuario P_Entidad)
        {
            return _ilogicaSQL.ConsultarUsuario(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(AgregarUsuarios))]
        public bool AgregarUsuarios(TblUsuario P_Entidad)
        {
            return _ilogicaSQL.AgregarUsuario(P_Entidad);
        }

        /// <summary>
        /// Metodo para Eliminar Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(EliminarUsuarios))]
        public bool EliminarUsuarios(TblUsuario P_Entidad)
        {
            return _ilogicaSQL.EliminarUsuario(P_Entidad);
        }
        #endregion

        #region Choferes
        /// <summary>
        /// Metodo para consultar Choferes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(ConsultarChoferes))]
        public IEnumerable<TblChofere> ConsultarChoferes(TblChofere P_Entidad)
        {
            return _ilogicaSQL.ConsultarChoferes(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Choferes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(AgregarChoferes))]
        public bool AgregarChoferes(TblChofere P_Entidad)
        {
            if (_ilogicaSQL.AgregarChoferes(P_Entidad) == true)
            {
                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se agrego el chofer " + P_Entidad.IdChoferes + " ,con la Unidad # " + P_Entidad.IdVehiculo;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }
        

        /// <summary>
        /// Metodo para Eliminar Choferes
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(EliminarChoferes))]
        public bool EliminarChoferes(TblChofere P_Entidad)
        {
            if(_ilogicaSQL.EliminarChoferes(P_Entidad) == true)
            {
                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se elimino el chofer " + P_Entidad.IdChoferes + " ,con la Unidad # " + P_Entidad.IdVehiculo;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }
       
        /// <summary>
        /// Metodo para Modificar Choferes
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route(nameof(ModificarChoferes))]
        public bool ModificarChoferes(TblChofere P_Entidad)
        {
            if (_ilogicaSQL.ModificarChoferes(P_Entidad) == true)
            {
                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se modifico el chofer " + P_Entidad.IdChoferes + " ,con la Unidad # " + P_Entidad.IdVehiculo;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Ruta
        /// <summary>
        /// Metodo para consultar Ruta
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(ConsultarRutas))]
        public IEnumerable<TblRutum> ConsultarRutas(TblRutum P_Entidad)
        {
            return _ilogicaSQL.ConsultarRuta(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Ruta
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(AgregarRutas))]
        public bool AgregarRutas(TblRutum P_Entidad)
        {
            if (_ilogicaSQL.AgregarRuta(P_Entidad) == true)
            {

                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se agrego la ruta " + P_Entidad.IdRuta + " ,el chofer asignado es " + P_Entidad.IdChoferes;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para Eliminar Ruta
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(EliminarRutas))]
        public bool EliminarRutas(TblRutum P_Entidad)
        {
            if (_ilogicaSQL.EliminarRuta(P_Entidad) == true)
            {

                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se elimino la ruta " + P_Entidad.IdRuta + " ,con el chofer asignado es " + P_Entidad.IdChoferes;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para Modificar Ruta
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(ModificarRutas))]
        public bool ModificarRutas(TblRutum P_Entidad)
        {
            if (_ilogicaSQL.ModificarRuta(P_Entidad) == true)
            {

                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se modifico la ruta " + P_Entidad.IdRuta + " ,el chofer asignado es " + P_Entidad.IdChoferes;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Buses
        /// <summary>
        /// Metodo para consultar Vehiculos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(nameof(ConsultarBuses))]
        public IEnumerable<TblVehiculo> ConsultarBuses([FromBody] TblVehiculo P_Entidad)
        {
            return _ilogicaSQL.ConsultarVehiculos(P_Entidad);
        }

        /// <summary>
        /// Metodo para Agregar Vehiculos
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(AgregarBuses))]
        public bool AgregarBuses(TblVehiculo P_Entidad)
        {
            
                if (_ilogicaSQL.AgregarVehiculos(P_Entidad) == true)
                {
                    Bitacora P_bitacora = new Bitacora();
                    P_bitacora.Accion = "Se agrego el vehiculo " + P_Entidad.IdVehiculo+" ,cuyo estado es"+P_Entidad.IdEstado;
                    P_bitacora.Fecha = DateTime.Now;
                    _ilogicaMongo.Agregar(P_bitacora);
                    return true;
                }
                else
                {
                    return false;
                }
         }

            /// <summary>
            /// Metodo para Eliminar Buses
            /// </summary>
            /// <returns></returns>
            [HttpPost]
        [Route(nameof(EliminarBuses))]
        public bool EliminarBuses(TblVehiculo P_Entidad)
        {
            if (_ilogicaSQL.EliminarVehiculos(P_Entidad) == true)
            {
                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se elimino el vehiculo " + P_Entidad.IdVehiculo;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para Modificar Buses
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(ModificarBuses))]
        public bool ModificarBuses(TblVehiculo P_Entidad)
        {
            if (_ilogicaSQL.ModificarVehiculos(P_Entidad) == true)
            {
                Bitacora P_bitacora = new Bitacora();
                P_bitacora.Accion = "Se modifivo el vehiculo " + P_Entidad.IdVehiculo;
                P_bitacora.Fecha = DateTime.Now;
                _ilogicaMongo.Agregar(P_bitacora);
                return true;
            }
            else
            {
                return false;
            }
        }
            #endregion

            #endregion
        }
}
