using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Utilities
{
    public class UsuarioUtil : IUsuarioUtil
    {

        public Usuario ConvertVO2Entity(UsuarioVo _c)
        {
            Usuario c = new Usuario()
            { id = _c.id,
                nombre = _c.nombre,
               Administrador=_c.Administrador
            };
            return c;
        }

        public UsuarioVo ConvertEntity2VO(Usuario _c)
        {
            UsuarioVo c = new UsuarioVo()
            {
                id = _c.id,
                nombre = _c.nombre,
                Administrador = _c.Administrador
            };
            return c;
        }
    }
}