using Microsoft.AspNetCore.Mvc;
using TallerMecanicoAPI.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecanicosController : ControllerBase
    {
        private static List<Mecanico> mecanicos = new()
{
    new Mecanico
    {
        Id = 1,
        Nombre = "Carlos Lopez",
        Especialidad = "Motor"
    }
};

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(mecanicos);
        }

        [HttpPost]
        public IActionResult Post(Mecanico mecanico)
        {
            mecanicos.Add(mecanico);
            return Ok(mecanico);
        }
    }
}