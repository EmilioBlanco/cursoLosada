using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Utilities
{
    public class MensajeUtil : IMensajeUtil
    {
        public IUsuarioUtil userUtil = new UsuarioUtil();
        public Mensaje ConvertVO2Entity(MensajeVo a)
        {
            Mensaje ap = new Mensaje()
            {
                id = a.id,
                EmisorID = a.EmisorID,
                ReceptorID=a.ReceptorID,
                fecha = a.fecha,
                asunto = a.asunto,
                cuerpo = a.cuerpo,
                bandeja=a.bandeja,
                leido=a.leido,
                eUsuario= userUtil.ConvertVO2Entity(a.eUsuario),
                rUsuario = userUtil.ConvertVO2Entity(a.rUsuario)
            };
            return ap;
        }

        public MensajeVo ConvertEntity2VO(Mensaje a)
        {
            MensajeVo ap = new MensajeVo()
            {
                id = a.id,
                EmisorID = a.EmisorID,
                ReceptorID = a.ReceptorID,
                fecha = a.fecha,
                asunto = a.asunto,
                cuerpo = a.cuerpo,
                bandeja = a.bandeja,
                leido = a.leido,
                eUsuario = userUtil.ConvertEntity2VO(a.eUsuario),
                rUsuario = userUtil.ConvertEntity2VO(a.rUsuario)
            };
            return ap;
        }
    }
}