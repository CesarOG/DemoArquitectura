using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio.Interface
{
    public interface IClienteServicio
    {
        void add(Cliente entity);
        void update(Cliente entity);
        void delete(Guid Id);
        IEnumerable<Cliente> Get();
        IEnumerable<Cliente> ListarClientesMayorEdad();
    }
}
