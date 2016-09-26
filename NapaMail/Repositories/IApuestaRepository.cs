using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Repositories
{
    public interface IApuestaRepository
    {
        bool Borrar(int _id);
        Mensaje Escribe(Mensaje _c);
        Mensaje Lee(int _id);
        List<Mensaje> Lista();
        Mensaje Modifica(Mensaje _c);
    }
}