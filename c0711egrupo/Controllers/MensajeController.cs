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
    public class MensajeController : ApiController
    {
        
    
        public List<MensajeVo> GetTodos()
        {
            using (CorreoDB db = new CorreoDB()) {
                System.Web.HttpContext.Current.Session["UsuariLoggeado"] = 1;
                int usuariID = (int)System.Web.HttpContext.Current.Session["UsuariLoggeado"];
                MensajeRepository MensajeRepository = new MensajeRepository();
                MensajeUtil MensajeUtil = new MensajeUtil();
                MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
                return MensajeService.Todos(usuariID);
            }
                

        }
        // GET: api/Mensajes/5
        public MensajeVo GetMensaje(int id)
        {
            CorreoDB db = new CorreoDB();
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            var test =  MensajeService.Lee(id);
            return test;
        }

        // PUT: api/Mensajes/5
        
        public MensajeVo PutMensaje(MensajeVo Mensaje)
        {
            CorreoDB db = new CorreoDB();
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            return MensajeService.Modifica(Mensaje);
        }

        // POST: api/Mensajes
        public MensajeVo PostMensaje(MensajeVo Mensaje)
        {
            CorreoDB db = new CorreoDB();
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            return MensajeService.Escribe(Mensaje);
        }

        // DELETE: api/Mensajes/5
        public bool DeleteMensaje(int id)
        {
            CorreoDB db = new CorreoDB();
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            return MensajeService.Borra(id);
        }
    }
}