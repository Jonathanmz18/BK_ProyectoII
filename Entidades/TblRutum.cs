using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TblRutum
    {
        public int IdRuta { get; set; }
        public string DescripcionRuta { get; set; }
        public int Paradas { get; set; }
        public decimal MontoFinal { get; set; }
        public decimal MontoInicial { get; set; }
        public int IdChoferes { get; set; }
        public string IdEstado { get; set; }

        public virtual TblChofere IdChoferesNavigation { get; set; }
        public virtual TblEstado IdEstadoNavigation { get; set; }
    }
}
