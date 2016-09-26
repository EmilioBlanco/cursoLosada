using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Services
{
    public interface IApuestaService
    {
        bool Borra(int _id);
        ApuestaVO Escribe(ApuestaVO _a);
        ApuestaVO Lee(int _id);
        List<ApuestaVO> Lista();
        ApuestaVO Modifica(ApuestaVO _a);
    }
}