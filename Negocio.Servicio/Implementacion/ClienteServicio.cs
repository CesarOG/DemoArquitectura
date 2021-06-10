using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;
using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Implementacion;
using Infra.Repositorio.Interface;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Servicio.Implementacion
{
    public class ClienteServicio : IClienteServicio
    {
        public IClienteRepositorio _clienteRepositorio { get; private set; }
        public ClienteServicio(TestContext context)
        {
            _clienteRepositorio = new ClienteRepositorio(context);
        }
        public void add(Cliente entity)
        {
            _clienteRepositorio.add(entity);
        }

        public void delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Get()
        {
            return _clienteRepositorio.Get();
        }

        public IEnumerable<Cliente> ListarClientesMayorEdad()
        {
            return _clienteRepositorio.ListarClientesMayorEdad();
        }

        public void update(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Cliente findById(int id)
        {
            return _clienteRepositorio.findById(id);
        }
    }
}
