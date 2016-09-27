using c11eindividual.Models;

namespace c11eindividual.Utilities
{
    public interface IMensajeUtil
    {
        MensajeVo ConvertEntity2VO(Mensaje a);
        Mensaje ConvertVO2Entity(MensajeVo a);
    }
}