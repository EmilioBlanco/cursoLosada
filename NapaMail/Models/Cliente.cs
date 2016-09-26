using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public string fechaAlta { get; set; }

        public Cliente() { }
    }

    
}