using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblChofere
    {
        public TblChofere()
        {
            TblRuta = new HashSet<TblRutum>();
        }

        public int IdChoferes { get; set; }
        public string Identidad { get; set; }
        public string NombreApellidos { get; set; }
        public string Edad { get; set; }
        public int IdVehiculo { get; set; }
        public string IdEstado { get; set; }

        public virtual TblEstado IdEstadoNavigation { get; set; }
        public virtual TblVehiculo IdVehiculoNavigation { get; set; }
        public virtual ICollection<TblRutum> TblRuta { get; set; }
    }
}
