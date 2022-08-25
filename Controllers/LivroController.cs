
using Microsoft.AspNetCore.Mvc;
using WebApiMongodb.Models;
using WebApiMongodb.services.LivrosServices;

namespace WebApiMongodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroServices _livroServices;

        public LivrosController(LivroServices livroServices)
        {
            _livroServices = livroServices;
        }

        [HttpGet]
        public async Task<List<Livro>> GetLivros()
            => await _livroServices.GetAsync();

        [HttpPost]
        public async Task<Livro> PostLivro(Livro livro)
        {
            await _livroServices.CreateAsync(livro);
            return livro;
        }

        [HttpPatch]
        public async Task UpdateLivro(string id, Livro livro)
        {
            await _livroServices.UpdateAsync(id, livro);
        }
    }
}
