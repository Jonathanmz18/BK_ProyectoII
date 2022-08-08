using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblEstado
    {
        public TblEstado()
        {
            TblChoferes = new HashSet<TblChofere>();
            TblPerfiles = new HashSet<TblPerfile>();
            TblRuta = new HashSet<TblRutum>();
            TblUsuarios = new HashSet<TblUsuario>();
            TblVehiculos = new HashSet<TblVehiculo>();
        }

        public string IdEstado { get; set; }
        public string DescEstado { get; set; }

        public virtual ICollection<TblChofere> TblChoferes { get; set; }
        public virtual ICollection<TblPerfile> TblPerfiles { get; set; }
        public virtual ICollection<TblRutum> TblRuta { get; set; }
        public virtual ICollection<TblUsuario> TblUsuarios { get; set; }
        public virtual ICollection<TblVehiculo> TblVehiculos { get; set; }
    }
}
