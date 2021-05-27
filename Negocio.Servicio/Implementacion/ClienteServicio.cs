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
        IClienteRepositorio _clienteRepositorio;
        public ClienteServicio(string cnString)
        {
            _clienteRepositorio = new ClienteRepositorio(cnString);
        }
        public void add(Cliente entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
