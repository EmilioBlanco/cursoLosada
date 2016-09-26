using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Utilities
{
    public class ApuestaUtil : IApuestaUtil
    {
        public Mensaje ConvertVO2Entity(ApuestaVO a)
        {
            Mensaje ap = new Mensaje()
            {
                id = a.id,
                cantidad = a.cantidad,
                fechaApuesta = a.fechaApuesta,
                textoUsuario = a.textoUsuario,
                UsrID = a.UsrID
            };
            return ap;
        }

        public ApuestaVO ConvertEntity2VO(Mensaje a)
        {
            ApuestaVO ap = new ApuestaVO()
            {
                id = a.id,
                cantidad = a.cantidad,
                fechaApuesta = a.fechaApuesta,
                textoUsuario = a.textoUsuario,
                UsrID = a.UsrID
            };
            return ap;
        }
    }
}