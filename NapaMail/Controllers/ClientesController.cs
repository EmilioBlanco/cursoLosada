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
    public class ClientesController : ApiController
    {
        private CorreoDB db = new CorreoDB();

        // GET: api/Clientes
        public List<ClienteVO> GetlistClientes()
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository clienteRepository = new UsuarioRepository();
            ClienteUtility clienteUtil = new ClienteUtility();
            ClienteService clienteService = new ClienteService(clienteRepository, clienteUtil);
            return clienteService.Lista();

        }

        // GET: api/Clientes/5

        public ClienteVO GetCliente(int id)
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository clienteRepository = new UsuarioRepository();
            ClienteUtility clienteUtil = new ClienteUtility();
            ClienteService clienteService = new ClienteService(clienteRepository, clienteUtil);
            return clienteService.Lee(id);
        }

        // PUT: api/Clientes/5
        public ClienteVO PutCliente(ClienteVO cliente)
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository clienteRepository = new UsuarioRepository();
            ClienteUtility clienteUtil = new ClienteUtility();
            ClienteService clienteService = new ClienteService(clienteRepository, clienteUtil);
            return clienteService.Modifica(cliente);
        }

        // POST: api/Clientes
        public ClienteVO PostCliente(ClienteVO cliente)
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository clienteRepository = new UsuarioRepository();
            ClienteUtility clienteUtil = new ClienteUtility();
            ClienteService clienteService = new ClienteService(clienteRepository, clienteUtil);
            return clienteService.Escribe(cliente);
        }

        // DELETE: api/Clientes/5
        public bool DeleteCliente(int id)
        {
            CorreoDB db = new CorreoDB();
            UsuarioRepository clienteRepository = new UsuarioRepository();
            ClienteUtility clienteUtil = new ClienteUtility();
            ClienteService clienteService = new ClienteService(clienteRepository, clienteUtil);
            return clienteService.Borra(id);
        }
    }     
}