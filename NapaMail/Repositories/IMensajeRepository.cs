using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Repositories
{
    public interface IMensajeRepository
    {
        bool Borrar(int _id);
        List<Mensaje> Entrada(int _id);
        Mensaje Escribe(Mensaje _c);
        Mensaje Lee(int _id);
        Mensaje Modifica(Mensaje _c);
        List<Mensaje> Papelera(int _id);
        List<Mensaje> Salida(int _id);
        List<Mensaje> Todos(int _id);
    }
}