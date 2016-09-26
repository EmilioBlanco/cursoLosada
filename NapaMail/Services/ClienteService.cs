using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using c11eindividual.Models;

namespace c11eindividual.Services
{
    public class ClienteService : IClienteService
    {
        IClienteRepository clienteRepository;
        IClienteUtility clienteUtil;

        public ClienteService (IClienteRepository repo, IClienteUtility util)
        {
            this.clienteRepository = repo;
            this.clienteUtil = util;
        }

        public List<ClienteVO> Lista()
        {
            List<ClienteVO> aRetornar = new List<ClienteVO>();
            foreach(Cliente c in clienteRepository.Lista())
            {
                aRetornar.Add(clienteUtil.ConvertEntity2VO(c));
            }
            return aRetornar;
        }

        public ClienteVO Lee(int _id)
        {
            Cliente c = clienteRepository.Lee(_id);
            ClienteVO c_vo = clienteUtil.ConvertEntity2VO(c);
            return c_vo;
        }

        public ClienteVO Escribe(ClienteVO _c)
        {
            Cliente c = clienteUtil.ConvertVO2Entity(_c);
            Cliente c2 = clienteRepository.Escribe(c);
            return clienteUtil.ConvertEntity2VO(c2);
        }

        public bool Borra (int _id)
        {
            bool a = clienteRepository.Borrar(_id);
            return a;
        }

        public ClienteVO Modifica (ClienteVO _c)
        {
            Cliente c = clienteUtil.ConvertVO2Entity(_c);
            ClienteVO c_vo = clienteUtil.ConvertEntity2VO(clienteRepository.Modifica(c));
            return c_vo;
        }
    }
}