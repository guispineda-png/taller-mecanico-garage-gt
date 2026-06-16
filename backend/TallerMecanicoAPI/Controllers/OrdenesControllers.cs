using Microsoft.AspNetCore.Mvc;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdenesController : ControllerBase
    {
        private static List<OrdenServicio> ordenes = new()
{
    new OrdenServicio
    {
        Id = 1,
        Descripcion = "Cambio de aceite",
        Estado = "Pendiente",
        VehiculoId = 1,
        MecanicoId = 1
    }
};

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ordenes);
        }

        [HttpPost]
        public IActionResult Post(OrdenServicio orden)
        {
            ordenes.Add(orden);
            return Ok(orden);
        }
    }
}