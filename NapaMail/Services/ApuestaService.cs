using c11eindividual.Models;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Services
{
    public class ApuestaService : IApuestaService
    {
        IApuestaRepository apuestaRepository;
        IApuestaUtil apuestaUtil;

        public ApuestaService(IApuestaRepository repo, IApuestaUtil util)
        {
            this.apuestaRepository = repo;
            this.apuestaUtil = util;
        }

        public List<ApuestaVO> Lista()
        {
            List<ApuestaVO> aRetornar = new List<ApuestaVO>();
            List<Apuesta> apuestas = apuestaRepository.Lista();
            foreach (Apuesta a in apuestas)
            {
                aRetornar.Add(apuestaUtil.ConvertEntity2VO(a));
            }
            return aRetornar;
        }

        public ApuestaVO Lee(int _id)
        {
            Apuesta a = apuestaRepository.Lee(_id);
            ApuestaVO a_vo = apuestaUtil.ConvertEntity2VO(a);
            return a_vo;
        }

        public ApuestaVO Escribe(ApuestaVO _a)
        {
            Apuesta a = apuestaUtil.ConvertVO2Entity(_a);
            Apuesta a2 = apuestaRepository.Escribe(a);
            return apuestaUtil.ConvertEntity2VO(a2);
        }

        public bool Borra(int _id)
        {
            return apuestaRepository.Borrar(_id);
        }

        public ApuestaVO Modifica(ApuestaVO _a)
        {
            Apuesta a = apuestaUtil.ConvertVO2Entity(_a);
            return apuestaUtil.ConvertEntity2VO(apuestaRepository.Modifica(a));
        }
    }
}