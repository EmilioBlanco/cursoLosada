using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using c11eindividual.Models;

namespace c11eindividual.Services
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository UsuarioRepository;
        IUsuarioUtil UsuarioUtil;

        public UsuarioService (IUsuarioRepository repo, IUsuarioUtil util)
        {
            this.UsuarioRepository = repo;
            this.UsuarioUtil = util;
        }

        public List<UsuarioVo> Lista()
        {
            List<UsuarioVo> aRetornar = new List<UsuarioVo>();
            foreach(Usuario c in UsuarioRepository.Lista())
            {
                aRetornar.Add(UsuarioUtil.ConvertEntity2VO(c));
            }
            return aRetornar;
        }

       
    }
}