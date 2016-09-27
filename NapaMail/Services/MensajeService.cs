using c11eindividual.Models;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Services
{
    public class MensajeService : IMensajeService
    {
        IMensajeRepository MensajeRepository;
        IMensajeUtil MensajeUtil;

        public MensajeService(IMensajeRepository repo, IMensajeUtil util)
        {
            this.MensajeRepository = repo;
            this.MensajeUtil = util;
        }

        public List<MensajeVo> Todos(int _id)
        {
            List<MensajeVo> aRetornar = new List<MensajeVo>();
            List<Mensaje> Mensajes = MensajeRepository.Todos(_id);
            foreach (Mensaje a in Mensajes)
            {
                aRetornar.Add(MensajeUtil.ConvertEntity2VO(a));
            }
            return aRetornar;
        }
        public List<MensajeVo> Papelera(int _id)
        {
            List<MensajeVo> aRetornar = new List<MensajeVo>();
            List<Mensaje> Mensajes = MensajeRepository.Papelera(_id);
            foreach (Mensaje a in Mensajes)
            {
                aRetornar.Add(MensajeUtil.ConvertEntity2VO(a));
            }
            return aRetornar;
        }
        public List<MensajeVo> Entrada(int _id)
        {
            List<MensajeVo> aRetornar = new List<MensajeVo>();
            List<Mensaje> Mensajes = MensajeRepository.Entrada(_id);
            foreach (Mensaje a in Mensajes)
            {
                aRetornar.Add(MensajeUtil.ConvertEntity2VO(a));
            }
            return aRetornar;
        }
        public List<MensajeVo> Salida(int _id)
        {
            List<MensajeVo> aRetornar = new List<MensajeVo>();
            List<Mensaje> Mensajes = MensajeRepository.Salida(_id);
            foreach (Mensaje a in Mensajes)
            {
                aRetornar.Add(MensajeUtil.ConvertEntity2VO(a));
            }
            return aRetornar;
        }
        public MensajeVo Lee(int _id)
        {
            Mensaje a = MensajeRepository.Lee(_id);
            MensajeVo a_vo = MensajeUtil.ConvertEntity2VO(a);
            return a_vo;
        }

        public MensajeVo Escribe(MensajeVo _a)
        {
            Mensaje a = MensajeUtil.ConvertVO2Entity(_a);
            Mensaje a2 = MensajeRepository.Escribe(a);
            return MensajeUtil.ConvertEntity2VO(a2);
        }

        public bool Borra(int _id)
        {
            return MensajeRepository.Borrar(_id);
        }

        public MensajeVo Modifica(MensajeVo _a)
        {
            Mensaje a = MensajeUtil.ConvertVO2Entity(_a);
            return MensajeUtil.ConvertEntity2VO(MensajeRepository.Modifica(a));
        }
    }
}