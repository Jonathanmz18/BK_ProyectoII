
using AccesosDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class LogicaMongo : ILogicaMongo
    {
        #region Atributos
        private readonly IAccesosDatosMongo _iaccesoMongo;
        #endregion


        #region Constructor
        public LogicaMongo(IAccesosDatosMongo iaccesoMongo)
        {
            _iaccesoMongo = iaccesoMongo;
        }
        #endregion

        #region Mongo_Bitacora
              
        /// <summary>
        /// Metodo para Agregar la coleccion Vehiculos-Buses en Mongo DB
        /// </summary>
        public bool Agregar(Bitacora P_Entidad)
        {
            return _iaccesoMongo.Agregar(P_Entidad);
        }

        #endregion

    }
}
