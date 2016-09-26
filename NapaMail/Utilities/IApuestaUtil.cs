using c11eindividual.Models;

namespace c11eindividual.Utilities
{
    public interface IApuestaUtil
    {
        ApuestaVO ConvertEntity2VO(Mensaje _a);
        Mensaje ConvertVO2Entity(ApuestaVO _a);
    }
}