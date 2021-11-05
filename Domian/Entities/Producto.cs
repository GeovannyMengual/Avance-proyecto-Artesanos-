using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Artesanos.Domian.Entities
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string NombreArtesania { get; set; }
        public string Descripcion { get; set; }
        public string TipoMaterial { get; set; }
    }
}
