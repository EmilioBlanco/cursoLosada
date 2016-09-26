using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Repositories
{
    public interface IClienteRepository
    {
        bool Borrar(int _id);
        Cliente Escribe(Cliente _c);
        Cliente Lee(int _id);
        List<Cliente> Lista();
        Cliente Modifica(Cliente _c);
    }
}