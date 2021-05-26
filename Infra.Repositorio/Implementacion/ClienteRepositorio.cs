using Dominio.Entidades.Model;
using Infra.AccesoDatos.OrigenDato;
using Infra.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio.Implementacion
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        readonly TestContext _cn;
        public ClienteRepositorio(TestContext cn)
        {
            _cn = cn;
        }

        public void add(Cliente entity)
        {
            _cn.Add(entity);
            _cn.SaveChanges();
        }

        public void delete(Guid Id)
        {
            var client = _cn.Cliente.Find(Id);
            _cn.Remove(client);
            _cn.SaveChanges();
        }

        public IEnumerable<Cliente> Get()
        {
            return _cn.Cliente;
        }

        public IEnumerable<Cliente> ListarClientesMayorEdad()
        {
            return _cn.Cliente.Where(x => x.Edad >= 18).ToList();
        }

        public void update(Cliente entity)
        {
            var client = _cn.Cliente.Find(entity.Id);
            _cn.Update(client);
            _cn.Entry(entity).State = EntityState.Modified;
            _cn.SaveChanges();
        }
    }
}
