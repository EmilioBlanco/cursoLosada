using c11eindividual.Models;

namespace c11eindividual.Utilities
{
    public interface IUsuarioUtil
    {
        UsuarioVo ConvertEntity2VO(Usuario _c);
        Usuario ConvertVO2Entity(UsuarioVo _c);
    }
}