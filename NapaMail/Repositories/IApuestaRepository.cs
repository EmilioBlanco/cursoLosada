using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Repositories
{
    public interface IApuestaRepository
    {
        bool Borrar(int _id);
        Apuesta Escribe(Apuesta _c);
        Apuesta Lee(int _id);
        List<Apuesta> Lista();
        Apuesta Modifica(Apuesta _c);
    }
}