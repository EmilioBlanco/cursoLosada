
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace c11eindividual.Models
{
    public class Mensaje
    {
        public int id { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
        public DateTime fecha { get; set; }
        public Boolean leido { get; set; }
        public Boolean bandeja { get; set; }
  
        public int EmisorID { get; set; }
        [ForeignKey("EmisorID")]
        public virtual Usuario eUsuario { get; set; }
        public int ReceptorID { get; set; }
        [ForeignKey("ReceptorID")]
        public virtual Usuario rUsuario { get; set; }

        public Mensaje() { }
    }
}