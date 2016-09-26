using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Models
{
    public class UsuarioVo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Boolean Administrador { get; set; }
        public UsuarioVo() { }
    }    
}