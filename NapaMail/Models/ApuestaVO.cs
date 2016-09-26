using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace c11eindividual.Models
{
    public class ApuestaVO
    {
        public int id { get; set; }
        public string fechaApuesta { get; set; }
        public string textoUsuario { get; set; }
        public double cantidad { get; set; }
        public int UsrID { get; set; }
        public virtual Cliente usuario { get; set; }

        public ApuestaVO() { }
    }
}