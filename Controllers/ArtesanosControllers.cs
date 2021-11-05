using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Artesanos.Domian.Entities;

namespace Proyecto_Artesanos.Controllers
{

     [ApiController]
    [Route("Api/[controller]")]
    public class ArtesanosController : ControllerBase
    {

              [HttpPost]
            public string POST(Artesanos Persona)
            {
                string Nombre= Persona.Nombre;
                string Asociacion= Persona.Asociacion;
                string Municipio =Persona.Municipio;
                string Email =Persona.Email;
                string Telefono= Persona.Telefono;
                string Mensaje;

                if(Nombre!="" && Asociacion!="" && Municipio!="" && Email!="" && Telefono!="")
                {   
                    Mensaje ="El artesano fue Registrado";
                    
                    
                }
                else
                {
                    Mensaje ="es imposible agregar un artesano";
                
                }
                return Mensaje;
            }
    }
}
