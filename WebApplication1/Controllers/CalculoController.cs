using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Valores;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    
    

    [RoutePrefix("api/calculo")]
    [EnableCorsAttribute("*", "*", "*")]
    public class CalculoController : ApiController
    {


        //[HttpPost]
        //[Authorize]
        //[Route("calcular")]
        //public IEnumerable<int> Calcular([FromBody] Numeros valores)
        //{

        //    int valor1 = valores.valor1;
        //    int valor2 = valores.valor2;

        //    int suma = valor1 + valor2;
        //    int resta = valor1 - valor2;
        //    int producto = valor1 * valor2;

        //    List<int> result = new List<int>();
        //    result.Add(suma);
        //    result.Add(resta);
        //    result.Add(producto);


        //    return result;


        //}


        [HttpPost]
        [Authorize]
        [Route("calcular")]
        public Resultado Calcular([FromBody] Numeros valores)
        {

            int valor1 = valores.valor1;
            int valor2 = valores.valor2;

            int suma = valor1 + valor2;
            int resta = valor1 - valor2;
            int producto = valor1 * valor2;
            Resultado result = new Resultado(suma, resta, producto);
            result.fraseSuma = "La suma de " + valor1 + " y " + valor2 + " es ";
            result.fraseResta = "La resta de " + valor1 + " y " + valor2 + " es ";
            result.fraseProducto = "El producto de " + valor1 + " y " + valor2 + " es ";

            return result;


        }

        [HttpPost]
        [Authorize]
        [Route("saludar")]
        public string Saludar([FromBody] Saludar valor)
        {
            var nombre = valor.Nombre;

            return nombre;


        }

        [HttpGet]
        [Authorize]
        [Route("GetPersonas")]
        public Persona[] GetPersonas()
        {
            Persona p1 = new Persona("Alberto", "Pérez", "648684838");
            Persona p2 = new Persona("Roberto", "Rodríguez", "648987562");
            Persona p3 = new Persona("José", "Méndez", "687126598");
            Persona p4 = new Persona("Iñigo", "Hernández", "645126598");
            Persona p5 = new Persona("Fernando", "Vidal", "648684838");
            Persona p6 = new Persona("Juan", "Hidalgo", "61254896");
            Persona p7 = new Persona("Sergio", "Cáceres", "698453212");
            Persona p8 = new Persona("Manuel", "Sánchez", "645982365");
            Persona p9 = new Persona("Rodrigo", "Martínez", "665489653");
            Persona p10 = new Persona("Eusebio", "Del Pozo", "634659845");

            Persona[] miArray = new Persona[] { p1, p2, p3, p4, p5, p6 ,p7 ,p8 ,p9 ,p10 };
            List<Persona> miLista = new List<Persona>();
            miLista.Add(p1);
            miLista.Add(p2);
            miLista.Add(p3);
            miLista.Add(p4);
            miLista.Add(p5);

            return miArray;


        }

        [HttpPost]
        [Authorize]
        [Route("EnviarTablas")]
        public string Tablas([FromBody] RecibirTablas tablas)
        {

            Persona[] tablas1 = tablas.tab1;
            Persona[] tablas2 = tablas.tab2;

    

           



            return"ok";
        }
    }
}
