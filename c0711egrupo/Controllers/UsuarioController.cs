using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using c11eindividual.BD;
using c11eindividual.Models;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using c11eindividual.Services;

namespace c11eindividual.Controllers
{
    public class UsuarioController : ApiController
    {

        // GET: api/Usuario
        public List<UsuarioVo> GetListUsuarios()
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            UsuarioUtil usuarioUtil = new UsuarioUtil();
            UsuarioService usuarioService = new UsuarioService(usuarioRepository, usuarioUtil);
            return usuarioService.Lista();
        }

        // POST: api/Usuario/5
        public UsuarioVo PutUsuario(UsuarioVo usuario)
        {
            CorreoDB db = new CorreoDB();
            System.Web.HttpContext.Current.Session["UsuariLoggeado"] = usuario;
            UsuarioVo user = (UsuarioVo)System.Web.HttpContext.Current.Session["UsuariLoggeado"];
            return user;

        }

        
    }
}     
