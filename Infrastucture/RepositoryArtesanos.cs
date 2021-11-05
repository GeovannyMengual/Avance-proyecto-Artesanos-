using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

using Proyecto_Artesanos.Domian.Entities;
using System.Threading.Tasks;
namespace Proyecto_Artesanos.Infrastucture
{
    public class RepositoryArtesanos
    {
         private readonly Proyecto_Artesanos  _Artesanos;

        public RepositoryArtesanos()
        {

            _Artesanos = new Proyecto_Artesanos();

        }

        ///un método en el cual se retorne la información de todas las artesanos.
        public IEnumerable<Artesano> GetAll()
        {
            var query = _Artesanos.artesanos.Select(Artesanos => Artesanos);
            return query;
        }
          public IEnumerable<Object> GetFields()
        {
            var query = _Artesanos.Artesanos.Select(Artesanos => new {
                Nombre = $"{Artesanos.Nombre}",
                Telefono = (Artesanos.TelefonoContacto),
                Email= Artesanos.Email
            });
            return query;
    }
    }
}
