using System.Collections.Generic;
using System.Web.Http;
using c11eindividual.BD;
using c11eindividual.Models;
using c11eindividual.Repositories;
using c11eindividual.Utilities;
using c11eindividual.Services;

namespace c11eindividual.Controllers
{
    public class PapeleraController : ApiController
    {
        private CorreoDB db = new CorreoDB();


        // GET: api/Mensaje/1
        public List<MensajeVo> GetPapelera()
        {
            UsuarioVo usuario = (UsuarioVo)System.Web.HttpContext.Current.Session["UsuariLoggeado"];
            MensajeRepository MensajeRepository = new MensajeRepository();
            MensajeUtil MensajeUtil = new MensajeUtil();
            MensajeService MensajeService = new MensajeService(MensajeRepository, MensajeUtil);
            return MensajeService.Papelera(usuario.id);

        }
       
    }
}