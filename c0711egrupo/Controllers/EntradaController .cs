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
    public class EntradaController : ApiController
    {
        private CorreoDB db = new CorreoDB();



        // GET: api/Mensajes/1
        public List<MensajeVo> GetEntrada()
        {
            UsuarioVo usuario = (UsuarioVo)System.Web.HttpContext.Current.Session["UsuariLoggeado"];
            CorreoDB db = new CorreoDB();
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            return MensajeService.Entrada(usuario.id);

        }
     
     
    }
}