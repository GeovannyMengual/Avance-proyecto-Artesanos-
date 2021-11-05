using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Artesanos.Domian.Entities
{
    public partial class Artesano
    {
        public int IdArtesano { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Asociacion { get; set; }
        public string Municipio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
