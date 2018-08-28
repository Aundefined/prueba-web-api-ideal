using System;
using System.Collections.Generic;
using System.Text;

namespace Valores
{
    public class Resultado
    {
       public int suma { get; set; }
       public int resta { get; set; }
       public int producto { get; set; }
       public string fraseSuma { get; set; }
       public string fraseResta { get; set; }
       public string fraseProducto { get; set; }

        public Resultado(int sum, int rest, int prod)
        {
            suma = sum;
            resta = rest;
            producto = prod;
        }
    }
}
