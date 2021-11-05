using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Artesanos.Domian.Entities
{
    public partial class Comercio
    {
        public int IdComercio { get; set; }
        public string NombreComercio { get; set; }
        public int TelefonoComercio { get; set; }
        public string Descripcion { get; set; }
    }
}
