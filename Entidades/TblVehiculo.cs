using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblVehiculo
    {
        public TblVehiculo()
        {
            TblChoferes = new HashSet<TblChofere>();
        }

        public int IdVehiculo { get; set; }
        public string PlacaVehiculo { get; set; }
        public string Fabricante { get; set; }
        public string AñoFabricacion { get; set; }
        public string IdEstado { get; set; }

        public virtual TblEstado IdEstadoNavigation { get; set; }
        public virtual ICollection<TblChofere> TblChoferes { get; set; }
    }
}
