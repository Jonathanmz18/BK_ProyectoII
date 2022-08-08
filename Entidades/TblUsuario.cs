using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblUsuario
    {
        public string Username { get; set; }
        public string Contrasena { get; set; }
        public string IdEstado { get; set; }
        public int IdPerfil { get; set; }

        public virtual TblEstado IdEstadoNavigation { get; set; }
        public virtual TblPerfile IdPerfilNavigation { get; set; }
    }
}
