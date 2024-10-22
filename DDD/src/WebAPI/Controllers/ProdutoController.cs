using DDD.src.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDD.src.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("Produtos")]
        public IActionResult GetTodosProdutos()
        {
           var produtos = _produtoService.ObterTodosProdutos();

            if (produtos == null)
            {
                Console.WriteLine("Nenhum produto encontrado!");
                return NotFound("Nenhum produto encontrado!");
            }

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduto(int id)
        {
            var produto = _produtoService.ObterProdutoPorId(id);

            if (produto == null)
            {
                Console.WriteLine($"Produto com id: {id}, não encontrado!");
                return NotFound($"Produto com id: {id}, não encontrado!");
            }

            Console.WriteLine(produto.Nome);
            return Ok(produto);
        }
    }
}
