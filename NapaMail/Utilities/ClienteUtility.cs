using c11eindividual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace c11eindividual.Utilities
{
    public class ClienteUtility : IClienteUtility
    {
        public Cliente ConvertVO2Entity(ClienteVO _c)
        {
            Cliente c = new Cliente()
            { id = _c.id, nombre = _c.nombre,
                apellidos = _c.apellidos,
                direccion = _c.direccion,
                dni = _c.dni,
                fechaAlta = _c.fechaAlta };
            return c;
        }

        public ClienteVO ConvertEntity2VO(Cliente _c)
        {
            ClienteVO c = new ClienteVO()
            {
                id = _c.id,
                nombre = _c.nombre,
                apellidos = _c.apellidos,
                direccion = _c.direccion,
                dni = _c.dni,
                fechaAlta = _c.fechaAlta
            };
            return c;
        }
    }
}