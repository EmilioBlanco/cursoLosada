using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
    public class ApuestasController : ApiController
    {
        private CorreoDB db = new CorreoDB();

        // GET: api/Apuestas
        public List<ApuestaVO> GetlistClientes()
        {
            CorreoDB db = new CorreoDB();
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            ApuestaUtil apuestaUtil = new ApuestaUtil();
            ApuestaService apuestaService = new ApuestaService(apuestaRepository, apuestaUtil);
            return apuestaService.Lista();

        }

        // GET: api/Apuestas/5
        public ApuestaVO GetApuesta(int id)
        {
            CorreoDB db = new CorreoDB();
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            ApuestaUtil apuestaUtil = new ApuestaUtil();
            ApuestaService apuestaService = new ApuestaService(apuestaRepository, apuestaUtil);
            return apuestaService.Lee(id);
        }

        // PUT: api/Apuestas/5
        
        public ApuestaVO PutApuesta(ApuestaVO apuesta)
        {
            CorreoDB db = new CorreoDB();
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            ApuestaUtil apuestaUtil = new ApuestaUtil();
            ApuestaService apuestaService = new ApuestaService(apuestaRepository, apuestaUtil);
            return apuestaService.Modifica(apuesta);
        }

        // POST: api/Apuestas
        public ApuestaVO PostApuesta(ApuestaVO apuesta)
        {
            CorreoDB db = new CorreoDB();
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            ApuestaUtil apuestaUtil = new ApuestaUtil();
            ApuestaService apuestaService = new ApuestaService(apuestaRepository, apuestaUtil);
            return apuestaService.Escribe(apuesta);
        }

        // DELETE: api/Apuestas/5
        public bool DeleteApuesta(int id)
        {
            CorreoDB db = new CorreoDB();
            ApuestaRepository apuestaRepository = new ApuestaRepository();
            ApuestaUtil apuestaUtil = new ApuestaUtil();
            ApuestaService apuestaService = new ApuestaService(apuestaRepository, apuestaUtil);
            return apuestaService.Borra(id);
        }
    }
}