﻿using System;
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
        private CorreoDB db = new CorreoDB();
      
        // GET: api/Usuario
        public List<UsuarioVo> GetlistUsuarios()
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository UsuarioRepository = new UsuarioRepository();
            UsuarioUtil UsuarioUtil = new UsuarioUtil();
            UsuarioService UsuarioService = new UsuarioService(UsuarioRepository, UsuarioUtil);
            return UsuarioService.Lista();

        }
        //POST: api/usuario
        [System.Web.Http.AcceptVerbs("POST")]
        [System.Web.Http.HttpPost]
        public int Post(int id){

            System.Web.HttpContext.Current.Session["UsuariLoggeado"]=id;

            return (int)System.Web.HttpContext.Current.Session["UsuariLoggeado"];

        }
        
       
    }     
}