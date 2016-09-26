using c11eindividual.Models;

namespace c11eindividual.Utilities
{
    public interface IApuestaUtil
    {
        ApuestaVO ConvertEntity2VO(Apuesta _a);
        Apuesta ConvertVO2Entity(ApuestaVO _a);
    }
}