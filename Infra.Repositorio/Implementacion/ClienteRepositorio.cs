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
    public class ClienteRepositorio : Generico<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(string cn) : base(cn)
        {
            //_cn = new TestContext(cn);
        }
        public IEnumerable<Cliente> ListarClientesMayorEdad()
        {
            return _cn.Cliente.Where(x => x.Edad >= 18).ToList();
        }
    }
}
