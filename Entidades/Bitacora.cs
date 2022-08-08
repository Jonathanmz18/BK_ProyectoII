using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entidades
{
    public class Bitacora
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string ID { get; set; }
    [BsonElement("Acción")]
    public string Accion { get; set; }

    [BsonElement("Fecha")]
    public DateTime Fecha { get; set; }

        public Bitacora()
    {
        ID = string.Empty;
        Accion = string.Empty;
        Fecha = DateTime.MinValue;
    }
 }
}
