using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace c11eindividual.Models
{
    public class MensajeVo

    {
        public int id { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
        public DateTime fecha { get; set; }
        public Boolean leido { get; set; }
        public Boolean bandeja { get; set; }
        public int EmisorID { get; set; }
        public virtual UsuarioVo eUsuario { get; set; }
        public int ReceptorID { get; set; }
        public virtual UsuarioVo rUsuario { get; set; }

        public MensajeVo() { }
    }
}