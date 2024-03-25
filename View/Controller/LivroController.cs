using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace View.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet("{id}")]
        public IActionResult GetLivro(int id)
        {
            var livro = _livroService.GetLivro(id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }
        // outros métodos do controlador relacionados a livros
    }
}
