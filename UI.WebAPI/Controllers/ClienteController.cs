using AutoMapper;
using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.Servicio;
using Negocio.Servicio.Implementacion;
using Negocio.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.WebAPI.Controllers
{
    [Route("Cliente")]
    [EnableCors("MyPolicy")]
    [Authorize]
    [ApiController]
    public class ClienteController : BaseController
    {
        public ClienteController(IMapper mapper, IUnitOfWork unitOfWork) : base(unitOfWork, mapper)
        {
        }

        [HttpGet]
        [Route("ListaClientes")]
        public IActionResult ListaClientes()
        {
            var Lista = _mapper.Map<List<ClienteViewModel>>(_unitOfWork.cliente.Get());

            return Ok(Lista);
        }

        [HttpGet]
        [Route("ListarClientesMayorEdad")]
        public IActionResult ListarClientesMayorEdad()
        {
            var Lista = _mapper.Map<List<ClienteViewModel>>(_unitOfWork.cliente.ListarClientesMayorEdad());

            return Ok(Lista);
        }

        [HttpGet]
        [Route("BuscarPorId/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var _cliente = _mapper.Map<ClienteViewModel>(_unitOfWork.cliente.findById(id));
            return Ok(_cliente);
        }

        [HttpPost]
        [Route("RegistrarCliente")]
        public IActionResult RegistrarCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            _unitOfWork.cliente.add(cliente);

            return Ok();
        }
        //TODO - Update, Delete y AddRange

    }
}
