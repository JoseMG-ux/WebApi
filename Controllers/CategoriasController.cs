using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
            ICategoriaService categoriaService;

            public CategoriasController(ICategoriaService _categoriaService)
            {
                categoriaService = _categoriaService;
            }

            [HttpGet]
            [Route("[action]")]
        public IActionResult Get()
            {
                return Ok(categoriaService.Get());
            } 
        
            [HttpPost]
            public IActionResult Post([FromBody] Categoria categoria)
            {
                categoriaService.Save(categoria);
                return Ok($"Categoria de nombre: {categoria.Nombre}, fue añadida correctamente.");
            }

            [HttpPut("{id}")]        
            public IActionResult Put(Guid id, [FromBody] Categoria categoria)
            {
                categoriaService.Update(id, categoria);
                return Ok("Categoria actualizada satisfactoriamente.");
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(Guid id)
            {
                categoriaService.Delete(id);

                return Ok($"Categoria eliminada correctamente.");
            }
    }
}
