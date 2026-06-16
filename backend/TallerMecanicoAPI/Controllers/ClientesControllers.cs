using Microsoft.AspNetCore.Mvc;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new()
{
    new Cliente
    {
        Id = 1,
        Nombre = "Juan Perez",
        Telefono = "55556666",
        Correo = "juan@gmail.com"
    }
};

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            clientes.Add(cliente);
            return Ok(cliente);
        }
    }
}