using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Services
{
    public interface IClienteService
    {
        bool Borra(int _id);
        ClienteVO Escribe(ClienteVO _c);
        ClienteVO Lee(int _id);
        List<ClienteVO> Lista();
        ClienteVO Modifica(ClienteVO _c);
    }
}