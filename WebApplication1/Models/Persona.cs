using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public Persona(string nom ,string ap ,string tel)
        {
            Nombre = nom;
            Apellido = ap;
            Telefono = tel;
        }
    }
}