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
        public ClienteRepositorio(TestContext context) : base(context)
        {
        }
        public IEnumerable<Cliente> ListarClientesMayorEdad()
        {
            return _context.Cliente.Where(x => x.Edad >= 18).ToList();
        }
    }
}
