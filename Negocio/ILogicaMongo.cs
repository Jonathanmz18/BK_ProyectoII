using AccesosDatos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
   public interface ILogicaMongo
    {
        #region Bitacora
        bool Agregar(Bitacora P_Entidad);
      
       
        #endregion
    }
}
