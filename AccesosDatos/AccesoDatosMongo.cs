using MongoDB.Bson;
using MongoDB.Driver;
using System;
using Entidades;
using System.Collections.Generic;


namespace AccesosDatos
{
    public class AccesoDatosMongo: IAccesosDatosMongo
    {

        #region Atributos

        // Se asigna la cadena de conexion con MongoDB en la nube o local

        private readonly string strConexion = @"mongodb+srv://UsuarioMongoUAM:_UAM2022@cluster0.bvsqf.mongodb.net/Autobusera?retryWrites=true&w=majority";


        //Objetos que se utilizaran para realizar la conexion al mongo  y a la base de datos
        private MongoClient InstanciaMongoDB;
        private IMongoDatabase Basedatos;

        // se establece el nombre de la base de datos
        private const string NombreBD = "Autobusera";

        #endregion

        #region Constructor

        public AccesoDatosMongo()
        {

            try
            {
                ObtenerConexion();
            }
            catch (MongoException exM)
            {

                throw exM;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (InstanciaMongoDB != null)
                    InstanciaMongoDB = null;
                if (Basedatos != null)
                    Basedatos = null;
            }
        }



        #endregion

        #region MetodosPrivados
        //Metodo para verificar la conexión de base de datos en MongoDB

        private bool ObtenerConexion()
        {

            bool ConexionStatus = false;

            try
            {
                //Inicializar los atributos para conexion

                InstanciaMongoDB = new MongoClient(strConexion);

                //Obtener la información de la BD

                Basedatos = InstanciaMongoDB.GetDatabase(NombreBD);

                //Verificar la conexion

                ConexionStatus = Basedatos.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            }
            catch (MongoException exM)
            {
                throw exM;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return ConexionStatus;
        }
        private void LimpiarAtributosGlobales()
        {
            if (InstanciaMongoDB != null)
                InstanciaMongoDB = null;
            if (Basedatos != null)
                Basedatos = null;
        }
        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Metodo para insetar en la coleccion Vehiculos-Buses
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// Entidad del Tipo Vehiculo
        /// Return True=correcto False=con error 
        /// <returns></returns>
        public bool Agregar(Bitacora P_Entidad)
        {

            ObtenerConexion();
            var Coleccion = Basedatos.GetCollection<Bitacora>("Vehiculos");
            Coleccion.InsertOne(P_Entidad);
            LimpiarAtributosGlobales();
            return true;
        }
        #endregion
    }
}

