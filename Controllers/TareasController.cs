using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareasController : ControllerBase
    {
        ITareaService tareasService;

        public TareasController(ITareaService _tareasService)
        {
            tareasService = _tareasService;
        }
        
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {
            return Ok(tareasService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarea tarea)
        {
            tareasService.Save(tarea);
            return Ok($"La tarea de titulo ({tarea.Titulo}) se añadio correctamente.");
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Tarea tarea)
        {
            tareasService.Update(id, tarea);
            return Ok($"Tarea con titulo ({tarea.Titulo}) actualizada satisfactoriamente.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            tareasService.Delete(id);

            return Ok("Tarea eliminada correctamente.");
        }
    }
}
