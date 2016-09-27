using System.Collections.Generic;
using c11eindividual.Models;

namespace c11eindividual.Services
{
    public interface IMensajeService
    {
        bool Borra(int _id);
        List<MensajeVo> Entrada(int _id);
        MensajeVo Escribe(MensajeVo _a);
        MensajeVo Lee(int _id);
        MensajeVo Modifica(MensajeVo _a);
        List<MensajeVo> Papelera(int _id);
        List<MensajeVo> Salida(int _id);
        List<MensajeVo> Todos(int _id);
    }
}