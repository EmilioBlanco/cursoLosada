using c11eindividual.Models;

namespace c11eindividual.Utilities
{
    public interface IClienteUtility
    {
        ClienteVO ConvertEntity2VO(Cliente _c);
        Cliente ConvertVO2Entity(ClienteVO _c);
    }
}