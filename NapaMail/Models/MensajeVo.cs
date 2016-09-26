﻿using System;
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
        public int emisor { get; set; }
        [ForeignKey("emisor")]
        public virtual UsuarioVo eUsuario { get; set; }
        public int receptor { get; set; }
        [ForeignKey("receptor")]
        public virtual UsuarioVo rUsuario { get; set; }

        public MensajeVo() { }
    }
}