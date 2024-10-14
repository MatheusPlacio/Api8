using Domain.Interfaces.IService;
using Microsoft.AspNetCore.Mvc;

namespace Api8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IClienteService _clienteService;

        public ClientesController(ILogger<ClientesController> logger,
                                  IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpGet("GetAllClientes")]
        public IActionResult Get()
        {
            var clientes = _clienteService.GetAllClientes();

            if (!clientes.Any())
                return NotFound("Nenhum cliente encontrado");

            return Ok(clientes);
        }

    }
}
