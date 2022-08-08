using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblPerfile
    {
        public TblPerfile()
        {
            TblUsuarios = new HashSet<TblUsuario>();
        }

        public int IdPerfil { get; set; }
        public string Descripcion { get; set; }
        public string IdEstado { get; set; }

        public virtual TblEstado IdEstadoNavigation { get; set; }
        public virtual ICollection<TblUsuario> TblUsuarios { get; set; }
    }
}
