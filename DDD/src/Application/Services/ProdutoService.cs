using DDD.src.Application.Services.Interfaces;
using DDD.src.Domain;
using DDD.src.Infrastructure.Repositories.Interfaces;

namespace DDD.src.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto ObterProdutoPorId(int id)
        {
            return _produtoRepository.ObterProdutoPorId(id);
        }
        public List<Produto> ObterTodosProdutos()
        {
            return _produtoRepository.ObterTodosProdutos();
        }
    }
}
