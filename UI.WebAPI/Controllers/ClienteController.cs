using AutoMapper;
using Dominio.Entidades.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.Servicio.Implementacion;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClienteServicio _clienteServicio;
        public ClienteController(IMapper mapper, IClienteServicio clienteServicio)
        {
            _mapper = mapper;
            _clienteServicio = clienteServicio;
        }
        [HttpGet]
        public IActionResult ListaClientes()
        {
            var Lista = _mapper.Map<List<ClienteViewModel>>(_clienteServicio.Get());

            return Ok(Lista);
        }
    }
}
