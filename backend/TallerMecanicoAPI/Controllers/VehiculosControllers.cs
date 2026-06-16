using Microsoft.AspNetCore.Mvc;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private static List<Vehiculo> vehiculos = new()
{
    new Vehiculo
    {
        Id = 1,
        Marca = "Toyota",
        Modelo = "Corolla",
        Placa = "P123ABC",
        ClienteId = 1
    }
};

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(vehiculos);
        }

        [HttpPost]
        public IActionResult Post(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
            return Ok(vehiculo);
        }
    }
}