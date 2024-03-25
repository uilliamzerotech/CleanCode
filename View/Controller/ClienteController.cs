using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace View.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var cliente = _clienteService.GetCliente(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        // outros métodos do controlador relacionados a clientes
    }
}
