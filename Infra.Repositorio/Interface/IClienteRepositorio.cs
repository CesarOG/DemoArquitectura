using Dominio.Entidades.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Interface
{
    public interface IClienteRepositorio:IGenerico<Cliente>
    {
        IEnumerable<Cliente> ListarClientesMayorEdad();
    }
}
